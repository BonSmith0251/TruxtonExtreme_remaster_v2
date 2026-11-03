namespace KANAI.Kernel;

[Token(Token = "0x2000008")]
public class AssetLoader : MonoBehaviourSingleton<AssetLoader>
{
	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <_load_Coroutine>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000037")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000038")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000039")]
		public string tpath; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400003A")]
		public AssetLoader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400003B")]
		private int <nkey>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400003C")]
		private AsyncOperationHandle<Object> <handle>5__3; //Field offset: 0x38

		[Token(Token = "0x17000014")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000088")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000015")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600008A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000085")]
		public <_load_Coroutine>d__18(int <>1__state) { }

		[Address(RVA = "0x1DF5490", Offset = "0x1DF4890", Length = "0x23F")]
		[Token(Token = "0x6000087")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000088")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600008A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF56D0", Offset = "0x1DF4AD0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000089")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000086")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private sealed class <_load_Coroutine>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400003D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400003E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400003F")]
		public AssetReference tasr; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000040")]
		public AssetLoader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000041")]
		private string <name>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000042")]
		private int <nkey>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000043")]
		private AsyncOperationHandle<Object> <handle>5__4; //Field offset: 0x40

		[Token(Token = "0x17000016")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600008E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000017")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000090")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600008B")]
		public <_load_Coroutine>d__19(int <>1__state) { }

		[Address(RVA = "0x1DF5710", Offset = "0x1DF4B10", Length = "0x2A8")]
		[Token(Token = "0x600008D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600008E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000090")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF59C0", Offset = "0x1DF4DC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600008F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600008C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000012")]
	private struct <_load_UniTask>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000045")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000046")]
		public string tpath; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000047")]
		public AssetLoader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000048")]
		private AsyncOperationHandle<Object> <handle>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000049")]
		private Awaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400004A")]
		private Awaiter <>u__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400004B")]
		private Awaiter <>u__3; //Field offset: 0x58

		[Address(RVA = "0x1DF5A00", Offset = "0x1DF4E00", Length = "0x699")]
		[Token(Token = "0x6000091")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000092")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private struct <_load_UniTask>d__21 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400004D")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004E")]
		public AssetReference ar; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400004F")]
		public AssetLoader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000050")]
		private AsyncOperationHandle<Object> <handle>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000051")]
		private Awaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000052")]
		private Awaiter <>u__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000053")]
		private Awaiter <>u__3; //Field offset: 0x58

		[Address(RVA = "0x1DF60A0", Offset = "0x1DF54A0", Length = "0x69E")]
		[Token(Token = "0x6000093")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000094")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private struct <_loadByLabel_UniTask>d__22 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002E")]
		public string tlabel; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002F")]
		public AssetLoader <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		private string <name>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		private int <nkey>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		private AsyncOperationHandle<IList`1<IResourceLocation>> <locationHandle>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		private AsyncOperationHandle<IList`1<T>> <handle>5__5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		private Awaiter <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B7BF30", Offset = "0x1B7B330", Length = "0x93C")]
		[Token(Token = "0x6000083")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000084")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000014")]
	private sealed class <_waitHandle>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000054")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000055")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000056")]
		public AsyncOperationHandle handle; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000057")]
		public AssetLoader <>4__this; //Field offset: 0x38

		[Token(Token = "0x17000018")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000098")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000019")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600009A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000095")]
		public <_waitHandle>d__23(int <>1__state) { }

		[Address(RVA = "0x1DF6740", Offset = "0x1DF5B40", Length = "0xB1")]
		[Token(Token = "0x6000097")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000098")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600009A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF6800", Offset = "0x1DF5C00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000099")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000096")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000009")]
	private sealed class <Load>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000017")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000018")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000019")]
		public string tpathall; //Field offset: 0x20

		[Token(Token = "0x1700000A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000066")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000068")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000063")]
		public <Load>d__0(int <>1__state) { }

		[Address(RVA = "0x1DF42C0", Offset = "0x1DF36C0", Length = "0x105")]
		[Token(Token = "0x6000065")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000066")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000068")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF43D0", Offset = "0x1DF37D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000067")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000064")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private sealed class <Load>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001C")]
		public AssetReference tasset; //Field offset: 0x20

		[Token(Token = "0x1700000C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600006C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600006E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000069")]
		public <Load>d__3(int <>1__state) { }

		[Address(RVA = "0x1DF4410", Offset = "0x1DF3810", Length = "0x138")]
		[Token(Token = "0x600006B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600006C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600006E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF4550", Offset = "0x1DF3950", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600006D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600006A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private sealed class <LoadAssets>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001F")]
		public AssetReference[] _lists; //Field offset: 0x20

		[Token(Token = "0x1700000E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000072")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000074")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600006F")]
		public <LoadAssets>d__4(int <>1__state) { }

		[Address(RVA = "0x1DF34F0", Offset = "0x1DF28F0", Length = "0x33E")]
		[Token(Token = "0x6000071")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000072")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000074")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF3A70", Offset = "0x1DF2E70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000073")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000070")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000C")]
	private sealed class <LoadByLabel>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000021")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		public string tlabel; //Field offset: 0x0

		[Token(Token = "0x17000010")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000078")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000011")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600007A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000075")]
		public <LoadByLabel>d__1`1(int <>1__state) { }

		[Address(RVA = "0x180FAA0", Offset = "0x180EEA0", Length = "0xC7")]
		[Token(Token = "0x6000077")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000078")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600007A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000079")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000076")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000D")]
	private sealed class <LoadPrefabs>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000023")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000024")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000025")]
		public Dictionary<String, Int32> _lists; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000026")]
		public string tpath; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000027")]
		public string ext; //Field offset: 0x30

		[Token(Token = "0x17000012")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600007E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000013")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000080")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600007B")]
		public <LoadPrefabs>d__2(int <>1__state) { }

		[Address(RVA = "0x1DF3F90", Offset = "0x1DF3390", Length = "0x2E3")]
		[Token(Token = "0x600007D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600007E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000080")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF4280", Offset = "0x1DF3680", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600007F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600007C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private struct <LoadUniTask>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000029")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002A")]
		public string path; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400002B")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x1DF4590", Offset = "0x1DF3990", Length = "0x23D")]
		[Token(Token = "0x6000081")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000082")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000015")]
	private Dictionary<Int32, AsyncOperationHandle> _handles; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000016")]
	private int _errorCount; //Field offset: 0x28

	[Token(Token = "0x17000009")]
	public int ErrorCount
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1DE4740", Offset = "0x1DE3B40", Length = "0xAE")]
	[Token(Token = "0x600005A")]
	private void _add(int nkey, string name, AsyncOperationHandle handle) { }

	[Address(RVA = "0x1DE4880", Offset = "0x1DE3C80", Length = "0xCC")]
	[Token(Token = "0x600005D")]
	private object _getAsset(int nkey) { }

	[Address(RVA = "0x108EF90", Offset = "0x108E390", Length = "0x26")]
	[Token(Token = "0x600005F")]
	public static int _getHashCode(string v) { }

	[Address(RVA = "0x1DE4950", Offset = "0x1DE3D50", Length = "0x84")]
	[IteratorStateMachine(typeof(<_load_Coroutine>d__19))]
	[Token(Token = "0x6000054")]
	private IEnumerator _load_Coroutine(AssetReference tasr) { }

	[Address(RVA = "0x1DE49E0", Offset = "0x1DE3DE0", Length = "0x84")]
	[IteratorStateMachine(typeof(<_load_Coroutine>d__18))]
	[Token(Token = "0x6000053")]
	private IEnumerator _load_Coroutine(string tpath) { }

	[Address(RVA = "0x1DE4A70", Offset = "0x1DE3E70", Length = "0xFA")]
	[AsyncStateMachine(typeof(<_load_UniTask>d__20))]
	[Token(Token = "0x6000055")]
	private UniTask _load_UniTask(string tpath) { }

	[Address(RVA = "0x1DE4B70", Offset = "0x1DE3F70", Length = "0xFA")]
	[AsyncStateMachine(typeof(<_load_UniTask>d__21))]
	[Token(Token = "0x6000056")]
	private UniTask _load_UniTask(AssetReference ar) { }

	[Address(RVA = "0x734FB0", Offset = "0x7343B0", Length = "0x10A")]
	[AsyncStateMachine(typeof(<_loadByLabel_UniTask>d__22`1))]
	[Token(Token = "0x6000057")]
	private UniTask _loadByLabel_UniTask(string tlabel) { }

	[Address(RVA = "0x1DE4E50", Offset = "0x1DE4250", Length = "0xF9")]
	[Token(Token = "0x600005B")]
	private void _release(int nkey) { }

	[Address(RVA = "0x1DE4C70", Offset = "0x1DE4070", Length = "0x1D2")]
	[Token(Token = "0x600005C")]
	private void _releaseAll() { }

	[Address(RVA = "0x1DE4F50", Offset = "0x1DE4350", Length = "0x90")]
	[IteratorStateMachine(typeof(<_waitHandle>d__23))]
	[Token(Token = "0x6000058")]
	private IEnumerator _waitHandle(AsyncOperationHandle handle) { }

	[Address(RVA = "0x1DE47F0", Offset = "0x1DE3BF0", Length = "0x88")]
	[Token(Token = "0x6000062")]
	public AssetLoader() { }

	[Address(RVA = "0x1DE3F80", Offset = "0x1DE3380", Length = "0x94")]
	[Token(Token = "0x6000050")]
	public static void ClearError() { }

	[Address(RVA = "0x734A90", Offset = "0x733E90", Length = "0x10C")]
	[Token(Token = "0x600004B")]
	public static T Get(AssetReference tpath) { }

	[Address(RVA = "0x734BA0", Offset = "0x733FA0", Length = "0x69")]
	[Token(Token = "0x6000048")]
	public static T Get(string tpath) { }

	[Address(RVA = "0x1DE4020", Offset = "0x1DE3420", Length = "0x17D")]
	[Token(Token = "0x6000047")]
	public static object Get(string tpath) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000061")]
	public int get_ErrorCount() { }

	[Address(RVA = "0x7346B0", Offset = "0x733AB0", Length = "0x32D")]
	[Token(Token = "0x600004A")]
	public static IList<DataT> GetByLabel(string label) { }

	[Address(RVA = "0x7349E0", Offset = "0x733DE0", Length = "0x38")]
	[Token(Token = "0x6000049")]
	public static IList<T> GetByLabel(string label) { }

	[Address(RVA = "0x734A20", Offset = "0x733E20", Length = "0x61")]
	[Token(Token = "0x6000060")]
	private static string GetTypeKey() { }

	[Address(RVA = "0x1DE41A0", Offset = "0x1DE35A0", Length = "0x51")]
	[Token(Token = "0x6000059")]
	private bool IsContainsKey(int nkey) { }

	[Address(RVA = "0x1DE4200", Offset = "0x1DE3600", Length = "0x9B")]
	[Token(Token = "0x600004F")]
	public static bool IsError() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600005E")]
	public static bool IsExist(string tfilepath) { }

	[Address(RVA = "0x1DE4480", Offset = "0x1DE3880", Length = "0x67")]
	[IteratorStateMachine(typeof(<Load>d__0))]
	[Token(Token = "0x6000041")]
	public static IEnumerator Load(string tpathall) { }

	[Address(RVA = "0x1DE44F0", Offset = "0x1DE38F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<Load>d__3))]
	[Token(Token = "0x6000044")]
	public static IEnumerator Load(AssetReference tasset) { }

	[Address(RVA = "0x1DE42A0", Offset = "0x1DE36A0", Length = "0x67")]
	[IteratorStateMachine(typeof(<LoadAssets>d__4))]
	[Token(Token = "0x6000045")]
	public static IEnumerator LoadAssets(AssetReference[] _lists) { }

	[Address(RVA = "0x734CA0", Offset = "0x7340A0", Length = "0x86")]
	[IteratorStateMachine(typeof(<LoadByLabel>d__1`1))]
	[Token(Token = "0x6000042")]
	public static IEnumerator LoadByLabel(string tlabel) { }

	[Address(RVA = "0x1DE4310", Offset = "0x1DE3710", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadPrefabs>d__2))]
	[Token(Token = "0x6000043")]
	public static IEnumerator LoadPrefabs(Dictionary<String, Int32> _lists, string tpath, string ext = ".prefab") { }

	[Address(RVA = "0x1DE43C0", Offset = "0x1DE37C0", Length = "0xBD")]
	[AsyncStateMachine(typeof(<LoadUniTask>d__5))]
	[Token(Token = "0x6000046")]
	public static UniTask LoadUniTask(string path) { }

	[Address(RVA = "0x1DE4560", Offset = "0x1DE3960", Length = "0x43")]
	[Token(Token = "0x6000052")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1DE4650", Offset = "0x1DE3A50", Length = "0xE3")]
	[Token(Token = "0x600004D")]
	public static void Release(AssetReference tasset) { }

	[Address(RVA = "0x1DE45B0", Offset = "0x1DE39B0", Length = "0x9A")]
	[Token(Token = "0x600004C")]
	public static void Release(string tpath) { }

	[Address(RVA = "0x734DF0", Offset = "0x7341F0", Length = "0xB0")]
	[Token(Token = "0x600004E")]
	public static void ReleaseByLabel(string tlabel) { }

	[Address(RVA = "0x1097480", Offset = "0x1096880", Length = "0x4")]
	[Token(Token = "0x6000051")]
	private void SetError(string errormsg) { }

}

