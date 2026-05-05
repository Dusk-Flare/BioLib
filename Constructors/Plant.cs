using UnityEngine;

namespace BioLib.Constructors
{
    //Consept class, not final, just for an example, i still need to check how the plants are structured in the game, and how to add them.
    internal class Plant
    {
        private readonly string plantID;
        private readonly Sprite[] sprites;
        public Plant(string plantID, Sprite[] sprites) 
        { 
            this.plantID = plantID;
            this.sprites = sprites;
        }
        internal class PlantBuilder
        {
            private string _plantID;
            private Sprite[] _sprites;
            public PlantBuilder(string plantID) 
            { 
                _plantID = plantID;
            }

            public PlantBuilder WithSprites(Sprite[] sprites)
            {
                _sprites = sprites;
                return this;
            }

            public Plant Build()
            {
                return new Plant(_plantID, _sprites);
            }
        }
    }
}
