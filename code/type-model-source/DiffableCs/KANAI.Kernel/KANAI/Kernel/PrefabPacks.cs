namespace KANAI.Kernel;

[CreateAssetMenu(menuName = "KANAI/PrefabPacks")]
[Token(Token = "0x2000029")]
public class PrefabPacks : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200002B")]
	private sealed class <LoadAssets>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B7")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B8")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B9")]
		public PrefabPacks <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000BA")]
		public MonoBehaviour _mono; //Field offset: 0x28

		[Token(Token = "0x17000025")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000162")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000026")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000164")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600015F")]
		public <LoadAssets>d__4(int <>1__state) { }

		[Address(RVA = "0x1DF3830", Offset = "0x1DF2C30", Length = "0x1F4")]
		[Token(Token = "0x6000161")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000162")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000164")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF3A30", Offset = "0x1DF2E30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000163")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000160")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200002A")]
	internal struct PrefabPackValue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B5")]
		public AssetReference baseAsset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B6")]
		public int createCount; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000B4")]
	private PrefabPackValue[] _assetPrefabs; //Field offset: 0x18

	[Token(Token = "0x17000024")]
	public PrefabPackValue[] AssetPrefabs
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x600015E")]
	public PrefabPacks() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600015B")]
	public PrefabPackValue[] get_AssetPrefabs() { }

	[Address(RVA = "0x1DED9E0", Offset = "0x1DECDE0", Length = "0x84")]
	[IteratorStateMachine(typeof(<LoadAssets>d__4))]
	[Token(Token = "0x600015C")]
	public IEnumerator LoadAssets(MonoBehaviour _mono) { }

	[Address(RVA = "0x1DEDA70", Offset = "0x1DECE70", Length = "0x140")]
	[Token(Token = "0x600015D")]
	public void ReleaseAssets() { }

}

