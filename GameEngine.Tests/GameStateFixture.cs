using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Tests
{
    public class GameStateFixture : IDisposable
    {
        public GameStateFixture()
        {
            State = new GameState();
        }

        public GameState State { get; private set; }
        public void Dispose()
        {
            // Dispose
        }
    }
}
