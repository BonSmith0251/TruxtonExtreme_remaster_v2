namespace DG.Tweening;

[Token(Token = "0x2000056")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000057")]
	internal class WaitForCompletion : CustomYieldInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000084")]
		private readonly Tween t; //Field offset: 0x10

		[Token(Token = "0x17000001")]
		public virtual bool keepWaiting
		{
			[Address(RVA = "0x5D27F0", Offset = "0x5D1BF0", Length = "0x33")]
			[Token(Token = "0x600013F")]
			 get { } //Length: 51
		}

		[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
		[Token(Token = "0x6000140")]
		public WaitForCompletion(Tween tween) { }

		[Address(RVA = "0x5D27F0", Offset = "0x5D1BF0", Length = "0x33")]
		[Token(Token = "0x600013F")]
		public virtual bool get_keepWaiting() { }

	}

	[Token(Token = "0x200005A")]
	internal class WaitForElapsedLoops : CustomYieldInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000087")]
		private readonly Tween t; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000088")]
		private readonly int elapsedLoops; //Field offset: 0x18

		[Token(Token = "0x17000004")]
		public virtual bool keepWaiting
		{
			[Address(RVA = "0x5D2880", Offset = "0x5D1C80", Length = "0x3E")]
			[Token(Token = "0x6000145")]
			 get { } //Length: 62
		}

		[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
		[Token(Token = "0x6000146")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops) { }

		[Address(RVA = "0x5D2880", Offset = "0x5D1C80", Length = "0x3E")]
		[Token(Token = "0x6000145")]
		public virtual bool get_keepWaiting() { }

	}

	[Token(Token = "0x2000059")]
	internal class WaitForKill : CustomYieldInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000086")]
		private readonly Tween t; //Field offset: 0x10

		[Token(Token = "0x17000003")]
		public virtual bool keepWaiting
		{
			[Address(RVA = "0x5D28C0", Offset = "0x5D1CC0", Length = "0x1E")]
			[Token(Token = "0x6000143")]
			 get { } //Length: 30
		}

		[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
		[Token(Token = "0x6000144")]
		public WaitForKill(Tween tween) { }

		[Address(RVA = "0x5D28C0", Offset = "0x5D1CC0", Length = "0x1E")]
		[Token(Token = "0x6000143")]
		public virtual bool get_keepWaiting() { }

	}

	[Token(Token = "0x200005B")]
	internal class WaitForPosition : CustomYieldInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000089")]
		private readonly Tween t; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008A")]
		private readonly float position; //Field offset: 0x18

		[Token(Token = "0x17000005")]
		public virtual bool keepWaiting
		{
			[Address(RVA = "0x5D2930", Offset = "0x5D1D30", Length = "0x62")]
			[Token(Token = "0x6000147")]
			 get { } //Length: 98
		}

		[Address(RVA = "0x5D28E0", Offset = "0x5D1CE0", Length = "0x44")]
		[Token(Token = "0x6000148")]
		public WaitForPosition(Tween tween, float position) { }

		[Address(RVA = "0x5D2930", Offset = "0x5D1D30", Length = "0x62")]
		[Token(Token = "0x6000147")]
		public virtual bool get_keepWaiting() { }

	}

	[Token(Token = "0x2000058")]
	internal class WaitForRewind : CustomYieldInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000085")]
		private readonly Tween t; //Field offset: 0x10

		[Token(Token = "0x17000002")]
		public virtual bool keepWaiting
		{
			[Address(RVA = "0x5D29A0", Offset = "0x5D1DA0", Length = "0x69")]
			[Token(Token = "0x6000141")]
			 get { } //Length: 105
		}

		[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
		[Token(Token = "0x6000142")]
		public WaitForRewind(Tween tween) { }

		[Address(RVA = "0x5D29A0", Offset = "0x5D1DA0", Length = "0x69")]
		[Token(Token = "0x6000141")]
		public virtual bool get_keepWaiting() { }

	}

	[Token(Token = "0x200005C")]
	internal class WaitForStart : CustomYieldInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008B")]
		private readonly Tween t; //Field offset: 0x10

		[Token(Token = "0x17000006")]
		public virtual bool keepWaiting
		{
			[Address(RVA = "0x5D2A10", Offset = "0x5D1E10", Length = "0xDA")]
			[Token(Token = "0x6000149")]
			 get { } //Length: 218
		}

		[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
		[Token(Token = "0x600014A")]
		public WaitForStart(Tween tween) { }

		[Address(RVA = "0x5D2A10", Offset = "0x5D1E10", Length = "0xDA")]
		[Token(Token = "0x6000149")]
		public virtual bool get_keepWaiting() { }

	}


}

