namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/ScriptBindings/PlayableSystems.bindings.h")]
[StaticAccessor("PlayableSystemsBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000005")]
internal static class PlayableSystems
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000008")]
	private class DataPlayableOutputList : IReadOnlyList<DataPlayableOutput>, IEnumerable<DataPlayableOutput>, IEnumerable, IReadOnlyCollection<DataPlayableOutput>
	{
		[Token(Token = "0x2000009")]
		private class DataPlayableOutputEnumerator : IEnumerator<DataPlayableOutput>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000012")]
			private DataPlayableOutputList m_List; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000013")]
			private int m_Index; //Field offset: 0x18

			[Token(Token = "0x1700000C")]
			public override DataPlayableOutput Current
			{
				[Address(RVA = "0x30D1200", Offset = "0x30D0600", Length = "0x1B5")]
				[Token(Token = "0x6000069")]
				 get { } //Length: 437
			}

			[Token(Token = "0x1700000D")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x30D11A0", Offset = "0x30D05A0", Length = "0x54")]
				[Token(Token = "0x600006A")]
				private get { } //Length: 84
			}

			[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
			[Token(Token = "0x6000068")]
			public DataPlayableOutputEnumerator(DataPlayableOutputList list) { }

			[Address(RVA = "0x1CC8D30", Offset = "0x1CC8130", Length = "0x13")]
			[Token(Token = "0x600006B")]
			public override void Dispose() { }

			[Address(RVA = "0x30D1200", Offset = "0x30D0600", Length = "0x1B5")]
			[Token(Token = "0x6000069")]
			public override DataPlayableOutput get_Current() { }

			[Address(RVA = "0x30D1170", Offset = "0x30D0570", Length = "0x25")]
			[Token(Token = "0x600006C")]
			public override bool MoveNext() { }

			[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
			[Token(Token = "0x600006D")]
			public override void Reset() { }

			[Address(RVA = "0x30D11A0", Offset = "0x30D05A0", Length = "0x54")]
			[Token(Token = "0x600006A")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000010")]
		private PlayableOutputHandle* m_Outputs; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000011")]
		private int m_Count; //Field offset: 0x18

		[Token(Token = "0x1700000B")]
		public override int Count
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x6000065")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700000A")]
		public override DataPlayableOutput Item
		{
			[Address(RVA = "0x30D1430", Offset = "0x30D0830", Length = "0x149")]
			[Token(Token = "0x6000064")]
			 get { } //Length: 329
		}

		[Address(RVA = "0x2708350", Offset = "0x2707750", Length = "0x36")]
		[Token(Token = "0x6000063")]
		public DataPlayableOutputList(PlayableOutputHandle* outputs, int count) { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000065")]
		public override int get_Count() { }

		[Address(RVA = "0x30D1430", Offset = "0x30D0830", Length = "0x149")]
		[Token(Token = "0x6000064")]
		public override DataPlayableOutput get_Item(int index) { }

		[Address(RVA = "0x30D13C0", Offset = "0x30D07C0", Length = "0x67")]
		[Token(Token = "0x6000066")]
		public override IEnumerator<DataPlayableOutput> GetEnumerator() { }

		[Address(RVA = "0x30D13C0", Offset = "0x30D07C0", Length = "0x67")]
		[Token(Token = "0x6000067")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000006")]
	internal sealed class PlayableSystemDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C4A150", Offset = "0x1C49550", Length = "0x124")]
		[Token(Token = "0x6000061")]
		public PlayableSystemDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000062")]
		public override void Invoke(IReadOnlyList<DataPlayableOutput> outputs) { }

	}

	[Token(Token = "0x2000007")]
	internal enum PlayableSystemStage : ushort
	{
		FixedUpdate = 0,
		FixedUpdatePostPhysics = 1,
		Update = 2,
		AnimationBegin = 3,
		AnimationEnd = 4,
		LateUpdate = 5,
		Render = 6,
	}

	[Token(Token = "0x4000005")]
	private static Dictionary<Int32, Type> s_SystemTypes; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static Dictionary<Int32, PlayableSystemDelegate> s_Delegates; //Field offset: 0x8
	[Token(Token = "0x4000007")]
	private static ReaderWriterLockSlim s_RWLock; //Field offset: 0x10

	[Address(RVA = "0x30D4070", Offset = "0x30D3470", Length = "0x188")]
	[Token(Token = "0x6000060")]
	private static PlayableSystems() { }

	[Address(RVA = "0x30D3E60", Offset = "0x30D3260", Length = "0xB")]
	[Token(Token = "0x600005E")]
	private static int CombineTypeAndIndex(int typeIndex, PlayableSystemStage stage) { }

	[Address(RVA = "0x30D3E70", Offset = "0x30D3270", Length = "0x1F9")]
	[RequiredByNativeCode]
	[Token(Token = "0x600005F")]
	private static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystemStage stage, IntPtr outputsPtr, int numOutputs) { }

}

