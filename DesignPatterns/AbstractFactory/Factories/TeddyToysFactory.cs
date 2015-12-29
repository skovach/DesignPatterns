﻿namespace AbstractFactory
{
    public class TeddyToysFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new TeddyBear();
        }
        public Cat GetCat()
        {
            return new TeddyCat();
        }
    }
}