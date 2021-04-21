using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GameEngine.Tests
{
    public class EnemyFactoryShould
    {
        [Fact]
        public void CreateNormalEnemyByDefault()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie");

            Assert.IsType<NormalEnemy>(enemy);
        }

        [Fact]
        public void CreateNormalEnemyByDefault_NotTypeExample()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie");

            Assert.IsNotType<DateTime>(enemy);
        }

        [Fact]
        public void CreateBossEnemy()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie King", true);

            Assert.IsType<BossEnemy>(enemy);
        }

        [Fact]
        public void CreateBossEnemy_CastReturnedTypeExample()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie King", true);

            // Assert and cast result
            BossEnemy boss = Assert.IsType<BossEnemy>(enemy);

            // Additional asserts on typed object
            Assert.Equal("Zombie King", boss.Name);
        }

        [Fact]
        public void CreateBossEnemy_AssertAssignableTypes()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie King", true);

            //Assert.IsType<Enemy>(enemy); // this will fail
            Assert.IsAssignableFrom<Enemy>(enemy);
        }
    }
}
