using System;

namespace Library
{
    public class Spells
    {
        public Spells (String name, String tipo, int health, int defense, int attack){
            this.Name = name;
            this.Tipo = tipo;
            this.Health = health;
            this.Defense = defense;
            this.Attack = attack;
        }

        public int Name{get; private set;}
        public int Tipo{get; private set;}
        public int Health{get; private set;}
        public int Defense{get; private set;}
        public int Attack{get; private set;}
    }
} 