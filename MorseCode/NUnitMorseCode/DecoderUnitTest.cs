using MorseCode;
using NUnit.Framework;

namespace NUnitMorseCode
{
    public class Tests
    {
        private MorseDecoder morseDecoder;
        [SetUp]
        public void Setup()
        {
            morseDecoder = new MorseDecoder();
        }

        [Test]
        public void CheckForOneWordPosTest()
        {
            string tes = ".... . .-.. .-.. ---";
            Assert.AreEqual(morseDecoder.Decoder(tes), "HELLO");
        }

        [Test]
        public void CheckForTwoWordPosTest()
        {
            string tes = ".... . .-.. .-.. ---   .-- --- .-. .-.. -..";
            Assert.AreEqual(morseDecoder.Decoder(tes), "HELLO WORLD");
        }

        [Test]
        public void CheckForThreeWordPosTest()
        {
            string tes = "-.-- --- ..-   .-.. . -   .... . .-.   --. ---";
            Assert.AreEqual(morseDecoder.Decoder(tes), "YOU LET HER GO");
        }

        [Test]
        public void CheckForNumbersNegTest()
        {
            string tes = "1   2   3   4   5";
            Assert.AreEqual(morseDecoder.Decoder(tes), "* * * * *");
        }

        [Test]
        public void CheckForNumbersLatNegTest()
        {
            string tes = "a   b   f   g";
            Assert.AreEqual(morseDecoder.Decoder(tes), "* * * *");
        }
        [Test]
        public void CheckForSpaceTwoNegTest()
        {
            string tes = ".-  -...  -.-.";
            Assert.AreEqual(morseDecoder.Decoder(tes), "A*B*C");
        }

        [Test]
        public void CheckForSpaceFourNegTest()
        {
            string tes = ".- -... -.-.    .- -...";
            Assert.AreEqual(morseDecoder.Decoder(tes), "ABC *AB");
        }
    }

}