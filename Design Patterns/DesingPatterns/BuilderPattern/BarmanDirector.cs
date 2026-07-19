using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.BuilderPattern
{
    public class BarmanDirector
    {
        public IBuilder _builder;
        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }
        
        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }


        public void PrepareMargarita() {

            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(100);
            _builder.AddIngredient("2 Limones");
            _builder.AddIngredient("pizca de sal ");
            _builder.AddIngredient("1/2 taza de tequila");
            _builder.AddIngredient("3/4 tazas de licor de naranja");
            _builder.AddIngredient("4 cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);

        }

        public void PreparePinaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(8);
            _builder.SetWater(100);
        }
    }
}
