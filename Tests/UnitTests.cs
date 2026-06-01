using NUnit.Framework;

namespace GameFrameX.Localization.Tests
{
    internal class UnitTests
    {
        private LocalizationManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new LocalizationManager();
        }

        [TearDown]
        public void Teardown()
        {
            _manager.RemoveAllRawStrings();
        }

        [Test]
        public void GetRawString_ReturnsNull_WhenKeyIsNull()
        {
            Assert.IsNull(_manager.GetRawString(null));
        }

        [Test]
        public void GetRawString_ReturnsNull_WhenKeyIsEmpty()
        {
            Assert.IsNull(_manager.GetRawString(string.Empty));
        }

        [Test]
        public void GetRawString_ReturnsNull_WhenKeyNotFound()
        {
            Assert.IsNull(_manager.GetRawString("nonexistent_key"));
        }

        [Test]
        public void GetRawString_ReturnsValue_WhenKeyExists()
        {
            _manager.AddRawString("test_key", "test_value");
            Assert.AreEqual("test_value", _manager.GetRawString("test_key"));
        }

        [Test]
        public void GetString_ReturnsNoKey_WhenKeyNotFound()
        {
            var result = _manager.GetString("missing_key");
            Assert.IsTrue(result.StartsWith("<NoKey>"));
        }

        [Test]
        public void GetString_WithArgs_ReturnsNoKey_WhenKeyNotFound()
        {
            var result = _manager.GetString("missing_key", "arg1");
            Assert.IsTrue(result.StartsWith("<NoKey>"));
        }

        [Test]
        public void GetString_WithArgs_ReturnsError_WhenFormatMismatch()
        {
            _manager.AddRawString("bad_format", "{0} {1} {2} {3}");
            var result = _manager.GetString("bad_format", "only_one_arg");
            Assert.IsTrue(result.StartsWith("<Error>"));
        }

        [Test]
        public void AddRawString_ReturnsTrue_WhenKeyIsValid()
        {
            Assert.IsTrue(_manager.AddRawString("key1", "value1"));
        }

        [Test]
        public void AddRawString_ReturnsFalse_WhenKeyIsNull()
        {
            Assert.IsFalse(_manager.AddRawString(null, "value"));
        }

        [Test]
        public void AddRawString_ReturnsFalse_WhenKeyAlreadyExists()
        {
            _manager.AddRawString("key1", "value1");
            Assert.IsFalse(_manager.AddRawString("key1", "value2"));
        }

        [Test]
        public void HasRawString_ReturnsTrue_WhenKeyExists()
        {
            _manager.AddRawString("key1", "value1");
            Assert.IsTrue(_manager.HasRawString("key1"));
        }

        [Test]
        public void HasRawString_ReturnsFalse_WhenKeyDoesNotExist()
        {
            Assert.IsFalse(_manager.HasRawString("nonexistent"));
        }

        [Test]
        public void RemoveRawString_RemovesKey()
        {
            _manager.AddRawString("key1", "value1");
            Assert.IsTrue(_manager.RemoveRawString("key1"));
            Assert.IsNull(_manager.GetRawString("key1"));
        }

        [Test]
        public void RemoveAllRawStrings_ClearsAll()
        {
            _manager.AddRawString("key1", "value1");
            _manager.AddRawString("key2", "value2");
            _manager.RemoveAllRawStrings();
            Assert.AreEqual(0, _manager.DictionaryCount);
        }
    }
}
