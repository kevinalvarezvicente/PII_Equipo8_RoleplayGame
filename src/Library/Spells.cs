using System;

namespace Library
{
    public class Spells
    {
        public string Name{get; private set;}
        public string Tipo{get; private set;}
        public int Defense{get; private set;}
        public int Attack{get; private set;}
        
        public Spells (String name, String tipo, int defense, int attack){
            this.Name = name;
            this.Tipo = tipo;
            this.Defense = defense;
            this.Attack = attack;
        }

        public void FireBall(CharacterWizard enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.Attack;
                    Console.WriteLine($"Al enemigo le queda {enemy.Health} de vida despues de la Bola de Fuego");
                    i = i + 1;
                } 

        }

    }
} 