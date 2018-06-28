﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_RS232.Logica
{
    class Player
    {
        int totalWalk = 0;

        int position = 0;

        int id;

        String name;

        bool brokeout = false;

        int money = 5000;

        public Player(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public int getTotalWalk()
        {
            return this.totalWalk;
        }

        public int tossDie(Die die)
        {
            int face = die.getFace();
            Console.WriteLine(this.getName() + " toss a die... Face is " + face);
            return face;
        }

        public int getCurrentPosition()
        {
            return this.position;
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public void nextTurn()
        {
            this.totalWalk++;
        }

        public String getName()
        {
            return this.name;
        }

        public int getMoney()
        {
            return this.money;
        }

        public int getID()
        {
            return this.id;
        }

        public void setBrokeOut(bool brokeout)
        {
            this.brokeout = brokeout;
        }

        public bool isBrokeOut()
        {
            return this.brokeout;
        }

        /*
            Devuelve el id del jugador en forma de String binario 
        */
        public String GetIdAsString()
        {
            return Convert.ToString(this.id, 2).PadLeft(2, '0');
        }
    }
}