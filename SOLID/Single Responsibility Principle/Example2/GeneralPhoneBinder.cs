﻿using System;

namespace SOLID.Single_Responsibility_Principle.Example2
{
    public class GeneralPhoneBinder : IPhoneBinder
    {
        public Phone CreatePhone(string[] data)
        {
            if (data.Length >= 2)
            {
                int price = 0;
                if (Int32.TryParse(data[1], out price))
                {
                    return new Phone { Model = data[0], Price = price };
                }
                else
                {
                    throw new Exception("Ошибка привязчика модели Phone. Некорректные данные для свойства Price");
                }
            }
            else
            {
                throw new Exception("Ошибка привязчика модели Phone. Недостаточно данных для создания модели");
            }
        }
    }
}
