﻿using MathFigures.Interfaces;

namespace MathFigures;

public abstract class Figure : IFigure
{   
    // возможные варианты реализации
    // 1. Если нам важна скорость работы и мы будем постоянно запрашивать площадь, но редко менять размер фигуры.
    // Можно вычислить площадь при первом запросе/при создании фигуры. 
    // В таком случае два варианта:
    //  [1] Храним ещё переменную(bool) которая показывает, валидная или нет площадь. Если нет(т.е. размеры фигуры менялись) - вычисляем и обновляем.
    //      Если правильная - возвращаем.
    //  [2] При обновлении размеров - вычисляем и обновляем площадь. В таком случае будет всегда поддерживаться правильная площадь.
    // 
    // 2. Если нам так часто площадь фигуры не нужна, можно просто вычислять её при запросе.
    // 
    // Для простоты реализации выберем второй вариант.
    public double Area => CalculateArea();

    protected abstract double CalculateArea();
}