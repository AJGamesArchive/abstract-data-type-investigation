using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_data_type_investigation
{
    /// <summary>
    /// Represents a player of the game and stores their attributes.
    /// </summary>
    internal class Player
    {
        private long id;
        private int health;
        private bool dead;

        /// <summary>
        /// Construct a player object with randomly generated starting health amounts.
        /// </summary>
        /// <param name="snowflake"></param>
        public Player(Snowflake snowflake)
        {
            id = snowflake.NextId();
            health = generateStartingHealth();
            dead = false;
        }

        /// <summary>
        /// Function to update a players health by a given value and mark a player as dead if their health drops to 0.
        /// Will not allow a player to have more than 100 health and will not allow a player to come back to life once dead.
        /// </summary>
        /// <param name="changeValue">
        /// The value to change the players health by. (Possitive for increase, Negative for decrease)
        /// </param>
        public void updateHealth(int changeValue)
        {
            if (health >= 100) return;
            if (dead) return;
            health += changeValue;
            if (health >= 100) health = 100;
            if (health <= 0) { health = 0; dead = true; }
            return;
        }

        /// <summary>
        /// .ToString() override to return the players details as a single string.
        /// </summary>
        /// <returns>
        /// Returns a string of all the players details.
        /// </returns>
        public override string ToString()
        {
            return $"Player: {id}\nHealth: {health}\nDead: {dead}";
        }

        /// <summary>
        /// Function to generate the starting health of a player.
        /// </summary>
        /// <returns>
        /// Returns a random integer between 10 and 90.
        /// </returns>
        private int generateStartingHealth()
        {
            Random random = new Random();
            return random.Next(10, 91);
        }

        /// <returns>
        /// Returns the players snowflake ID.
        /// </returns>
        public long getSnowflake()
        {
            return id;
        }
    }
}
