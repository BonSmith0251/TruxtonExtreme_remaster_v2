namespace InGame.Kernel.BG;

[Token(Token = "0x2000240")]
public class InGameBGObject : InGameObjectBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000241")]
	private sealed class <FakeEntry>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013E1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40013E2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40013E3")]
		public InGameBGObject <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40013E4")]
		private AreaTimelineMarker[] <areas>5__2; //Field offset: 0x28

		[Token(Token = "0x17000239")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600113C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700023A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600113E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6001139")]
		public <FakeEntry>d__4(int <>1__state) { }

		[Address(RVA = "0x1D1A730", Offset = "0x1D19B30", Length = "0x19E")]
		[Token(Token = "0x600113B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600113C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600113E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D1A8D0", Offset = "0x1D19CD0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600113D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600113A")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40013D3")]
	private InGameObject[] _objects; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40013D4")]
	private Material _skyboxMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40013D5")]
	private Color _skyboxShadowColor; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40013D6")]
	private bool _useFog; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Token(Token = "0x40013D7")]
	private Color _fogColor; //Field offset: 0x8C
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	[Token(Token = "0x40013D8")]
	private FogMode _fogMode; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40013D9")]
	private float _fogStart; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[Token(Token = "0x40013DA")]
	private float _fogEnd; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40013DB")]
	private float _reflectionIntensity; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	[Token(Token = "0x40013DC")]
	private float _ambientIntensity; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x40013DD")]
	private int _reflectionBounces; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[Token(Token = "0x40013DE")]
	private int _reflectionResolution; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x40013DF")]
	private DefaultReflectionMode _reflectionMode; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	[Token(Token = "0x40013E0")]
	private AmbientMode _ambientMode; //Field offset: 0xBC

	[Address(RVA = "0x1D153A0", Offset = "0x1D147A0", Length = "0x60")]
	[Token(Token = "0x6001138")]
	public InGameBGObject() { }

	[Address(RVA = "0x1D14EF0", Offset = "0x1D142F0", Length = "0xB5")]
	[Token(Token = "0x6001134")]
	public virtual void EntryInGame() { }

	[Address(RVA = "0x1D14FB0", Offset = "0x1D143B0", Length = "0x67")]
	[IteratorStateMachine(typeof(<FakeEntry>d__4))]
	[Token(Token = "0x6001137")]
	public IEnumerator FakeEntry() { }

	[Address(RVA = "0x1D15020", Offset = "0x1D14420", Length = "0x18C")]
	[Token(Token = "0x6001133")]
	public void InitializeBG(List<MaxParticleData> maxParticlesSetting, bool isArena) { }

	[Address(RVA = "0x1D151B0", Offset = "0x1D145B0", Length = "0xA5")]
	[Token(Token = "0x6001135")]
	public virtual void RemoveInGame() { }

	[Address(RVA = "0x1D15260", Offset = "0x1D14660", Length = "0x131")]
	[Token(Token = "0x6001136")]
	public void UpdateSkyBox() { }

}

