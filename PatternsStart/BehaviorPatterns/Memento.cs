using BehaviorPatterns.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsStart.BehaviorPatterns
{
    class Memento : IPattern
    {
        public void Start()
        {

            Hero hero = new Hero();
            hero.Shoot(); // делаем выстрел, осталось 9 патронов
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState()); // сохраняем игру

            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            hero.RestoreState(game.History.Pop());

            hero.Shoot(); //делаем выстрел, осталось 8 патронов
        }
    }
}
