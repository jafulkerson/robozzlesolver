using System;

namespace RoboZZle.GameModel
{
    public class StartPositionChangedEventArgs : EventArgs
	{
		public Coord OldPosition { get; private set; }
		
		public Coord NewPosition { get; private set; }

		public StartPositionChangedEventArgs(Coord oldPosition, Coord newPosition)
		{
			this.OldPosition = oldPosition;
			this.NewPosition = newPosition;
		}
	}
}