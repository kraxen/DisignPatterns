using BehaviorPatterns.Command;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class CommandPattern : IPattern
    {
        public void Start()
        {
            TV tv = new TV();
            MultiPult mPult = new MultiPult();
            mPult.SetCommand(0, new TVOnCommand(tv));
            mPult.SetCommand(1, new VolumeCommand(tv.volume));
            // включаем телевизор
            mPult.PressButton(0);
            // увеличиваем громкость
            mPult.PressButton(1);
            mPult.PressButton(1);
            mPult.PressButton(1);
            // действия отмены
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();
        }
    }
}
