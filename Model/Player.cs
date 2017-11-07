using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    public class Player
    {
        private readonly long id;
        private readonly bool isMe;
        private readonly bool isStrategyCrashed;
        private readonly int score;
        private readonly int remainingActionCooldownTicks;

        public Player(long id, bool isMe, bool isStrategyCrashed, int score, int remainingActionCooldownTicks)
        {
            this.id = id;
            this.isMe = isMe;
            this.isStrategyCrashed = isStrategyCrashed;
            this.score = score;
            this.remainingActionCooldownTicks = remainingActionCooldownTicks;
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id => id;

        /// <summary>
        /// Это я
        /// </summary>
        public bool IsMe => isMe;

        /// <summary>
        /// Упала ли стратегия
        /// </summary>
        public bool IsStrategyCrashed => isStrategyCrashed;

        /// <summary>
        /// Очки
        /// </summary>
        public int Score => score;

        /// <summary>
        /// Количество тиков до следующего возможного действия
        /// </summary>
        public int RemainingActionCooldownTicks => remainingActionCooldownTicks;
    }
}