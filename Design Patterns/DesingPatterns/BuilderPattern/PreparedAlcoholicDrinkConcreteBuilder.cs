using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace DesingPatterns.BuilderPattern
{
    public class PreparedAlcoholicDrinkConcreteBuilder : IBuilder
    {
        private PreparedDrink _preparedDrink;

        public PreparedAlcoholicDrinkConcreteBuilder()
        {
            Reset(); //  mi objeto interno se va crear en controtura 
        }
        public void AddIngredient(string ingredient)
        {
            if(_preparedDrink.Ingredients == null)
            {
                _preparedDrink.Ingredients = new List<string>();
            }
            _preparedDrink.Ingredients.Add(ingredient); // Estamos agregrando un ingrediente 
        }

        public void Mix()
        {
            
            string ingredients = _preparedDrink.Ingredients.Aggregate((current, next) => current + ", " + next);

            _preparedDrink.Result = $"Mezclando los ingredientes: {ingredients} con {_preparedDrink.Water} ml de agua, {_preparedDrink.Milk} ml de leche y {_preparedDrink.Alcohol} ";

            Console.WriteLine( "Se mesclaron los ingredientes"  );
        }

        public void Reset()
        {
            _preparedDrink = new PreparedDrink(); //  mi objeto interno se va crear en controtura 

        }

        public void Rest(int time)
        {
           Thread.Sleep(time); // Simula un tiempo de reposo para la bebida
            Console.WriteLine("Listo para beber");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _preparedDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _preparedDrink.Water = water;
        }

        public PreparedDrink GetPreparedDrink()
        {
            return _preparedDrink;
        }


    }
}
