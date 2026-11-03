namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x2000025")]
public struct PhysicsLayers
{
	[Token(Token = "0x2000026")]
	internal class LayerNames : ISerializationCallbackReceiver
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40000DE")]
		internal String[] m_Names; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000DF")]
		private Dictionary<String, Int32> m_NameMap; //Field offset: 0x18

		[Token(Token = "0x17000043")]
		internal static LayerNames DefaultLayerNames
		{
			[Address(RVA = "0x3126600", Offset = "0x3125A00", Length = "0x123")]
			[Token(Token = "0x6000133")]
			internal get { } //Length: 291
		}

		[Token(Token = "0x17000042")]
		private Dictionary<String, Int32> NameMap
		{
			[Address(RVA = "0x3126730", Offset = "0x3125B30", Length = "0x7F")]
			[Token(Token = "0x6000130")]
			private get { } //Length: 127
		}

		[Token(Token = "0x17000041")]
		private String[] Names
		{
			[Address(RVA = "0x31267B0", Offset = "0x3125BB0", Length = "0x61")]
			[Token(Token = "0x600012F")]
			private get { } //Length: 97
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000134")]
		public LayerNames() { }

		[Address(RVA = "0x3126600", Offset = "0x3125A00", Length = "0x123")]
		[Token(Token = "0x6000133")]
		internal static LayerNames get_DefaultLayerNames() { }

		[Address(RVA = "0x3126730", Offset = "0x3125B30", Length = "0x7F")]
		[Token(Token = "0x6000130")]
		private Dictionary<String, Int32> get_NameMap() { }

		[Address(RVA = "0x31267B0", Offset = "0x3125BB0", Length = "0x61")]
		[Token(Token = "0x600012F")]
		private String[] get_Names() { }

		[Address(RVA = "0x31264E0", Offset = "0x31258E0", Length = "0x11F")]
		[Token(Token = "0x6000132")]
		public override void OnAfterDeserialize() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000131")]
		public override void OnBeforeSerialize() { }

	}


}

