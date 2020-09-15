﻿using System;
using System.Collections.Generic;
using static Exercice1.Dice;

namespace Exercice1
{
    class Game
    {
        private Random r = new Random();
        private Dictionary<Dice, int> diceTrack;
        private int? myDiceNumber;
        private const int maxDiceNumber = 5;
        private const int minDiceNumber = 1;

        public int? MyDiceNumber
        {
            get { return myDiceNumber; }
            set
            {
                if (MyDiceNumber <= maxDiceNumber && MyDiceNumber >= minDiceNumber)
                {
                    myDiceNumber = value;
                }
                else
                {
                    MyDiceNumber = null;
                    Console.WriteLine($"Le nombre de dé doit être compris entre 1 et 5.");
                }

            }
        }

        public FacesEnum MyFaceType { get; set; }

        public Game(int nbDice, FacesEnum faceType)
        {
            MyDiceNumber = nbDice;
            MyFaceType = faceType;
            diceTrack = new Dictionary<Dice, int>();

            for (int i = 0; i < MyDiceNumber; i++)
            {
                new Dice(faceType, new Dice.ColorEnum());
            }
        }

        public bool UpdateDiceColor(ColorEnum previousColor, ColorEnum newColor)
        {
            throw new NotImplementedException();
        }

        public bool ThrowOneDice()
        {

            throw new NotImplementedException();
        }
        public bool ThrowAllDice()
        {

            throw new NotImplementedException();
        }

        public void MyMethod()
        {

            throw new NotImplementedException();
        }
        public string GetDiceTrackResult()
        {

            throw new NotImplementedException();
        }

        private Dice getTrackDiceByColor(ColorEnum color)
        {

            throw new NotImplementedException();
        }
        private Dice getGameDiceByColor(ColorEnum color)
        {

            throw new NotImplementedException();
        }
        public bool ThrowOneTrackDice(ColorEnum color)
        {

            throw new NotImplementedException();
        }
        public string GetSortedDiceTrackResult()
        {

            throw new NotImplementedException();
        }
        public bool SwapDice(ColorEnum previousColor, ColorEnum newColor)
        {

            throw new NotImplementedException();
        }
    }
}