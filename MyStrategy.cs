using Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk
{
    public sealed class MyStrategy : IStrategy
    {
        SimpleIoc _ioc;

        public MyStrategy()
        {
            _ioc = new SimpleIoc();
            _ioc.AddTransient<IWorldState, WorldState>();
            _ioc.AddSingleton<IStatistics, Statistics>();
        }

        public void Move(Player me, World world, Game game, Move move)
        {
            if (world.TickIndex == 0) {
                move.Action = ActionType.ClearAndSelect;
                move.VehicleType = VehicleType.Fighter;
                move.Right = world.Width;
                move.Bottom = world.Height;
                return;
            }

            if (world.TickIndex == 1) {
                move.Action = ActionType.Move;
                move.X = world.Width;
                move.Y = world.Height;
            }
        }
    }
}