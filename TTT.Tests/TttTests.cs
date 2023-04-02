using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TTT.TicTacToe.Logic;
using TTT.TicTacToe.Models;

namespace TTT.Tests
{
    [TestClass]
    public class TttTests
    {
        [TestMethod]
        public void CheckVictory_123andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 1, Value = playerSymbol},
                new PlayingField{Id = 2, Value = playerSymbol},
                new PlayingField{Id = 3, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckVictory_456andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 4, Value = playerSymbol},
                new PlayingField{Id = 5, Value = playerSymbol},
                new PlayingField{Id = 6, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_789andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 7, Value = playerSymbol},
                new PlayingField{Id = 8, Value = playerSymbol},
                new PlayingField{Id = 9, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_147andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 1, Value = playerSymbol},
                new PlayingField{Id = 4, Value = playerSymbol},
                new PlayingField{Id = 7, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_258andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 2, Value = playerSymbol},
                new PlayingField{Id = 5, Value = playerSymbol},
                new PlayingField{Id = 8, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_369andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 3, Value = playerSymbol},
                new PlayingField{Id = 6, Value = playerSymbol},
                new PlayingField{Id = 9, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_159andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 1, Value = playerSymbol},
                new PlayingField{Id = 5, Value = playerSymbol},
                new PlayingField{Id = 9, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_357andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 3, Value = playerSymbol},
                new PlayingField{Id = 5, Value = playerSymbol},
                new PlayingField{Id = 7, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_1456andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 1, Value = playerSymbol},
                new PlayingField{Id = 4, Value = playerSymbol},
                new PlayingField{Id = 5, Value = playerSymbol},
                new PlayingField{Id = 6, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForVictory_1259andTrue_ReturnTrue()
        {
            bool expected = true;
            bool playerSymbol = true;
            List<PlayingField> playingSymbolFields = new()
            {
                new PlayingField{Id = 1, Value = playerSymbol},
                new PlayingField{Id = 2, Value = playerSymbol},
                new PlayingField{Id = 5, Value = playerSymbol},
                new PlayingField{Id = 9, Value = playerSymbol}
            };

            bool actual = TttLogic.CheckVictory(playingSymbolFields);

            Assert.AreEqual(expected, actual);
        }
    }
}
