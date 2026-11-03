namespace OutGame;

[Token(Token = "0x2000046")]
public abstract class ModelGamePlayBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000047")]
	private sealed class <>c__DisplayClass26_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000103")]
		public bool isOpenDoor; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001D7")]
		public <>c__DisplayClass26_0() { }

		[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
		[Token(Token = "0x60001D8")]
		internal void <PlayTakeoffMovie>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000048")]
	private sealed class <>c__DisplayClass49_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000104")]
		public StageResultPopupContent rcontent; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000105")]
		public StageInformation sinfo; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000106")]
		public PlayerInformation pinfo; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000107")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000108")]
		public PopupBase windowPopup; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001D9")]
		public <>c__DisplayClass49_0() { }

		[Address(RVA = "0x21CB9F0", Offset = "0x21CADF0", Length = "0x12C")]
		[Token(Token = "0x60001DA")]
		internal void <StageResultPopup>b__0(PopupBase popup, PopupContentBase tcontent) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000049")]
	private sealed class <CreateAndStartPlayer>d__31 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000109")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010A")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010B")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000062")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001DE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000063")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001E0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001DB")]
		public <CreateAndStartPlayer>d__31(int <>1__state) { }

		[Address(RVA = "0x21C5EA0", Offset = "0x21C52A0", Length = "0xB4")]
		[Token(Token = "0x60001DD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001DE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001E0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C5F60", Offset = "0x21C5360", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001DF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001DC")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004A")]
	private sealed class <CreateOnlyPlayer>d__32 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010E")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400010F")]
		private InGameManager <gm>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000110")]
		private PFlag <pflag>5__3; //Field offset: 0x30

		[Token(Token = "0x17000064")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001E4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000065")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001E6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001E1")]
		public <CreateOnlyPlayer>d__32(int <>1__state) { }

		[Address(RVA = "0x21C5FA0", Offset = "0x21C53A0", Length = "0x630")]
		[Token(Token = "0x60001E3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001E4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001E6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C65E0", Offset = "0x21C59E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001E5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001E2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private sealed class <CreatePlayer>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000112")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000113")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000066")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001EA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000067")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001EC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001E7")]
		public <CreatePlayer>d__33(int <>1__state) { }

		[Address(RVA = "0x21C6620", Offset = "0x21C5A20", Length = "0xF4")]
		[Token(Token = "0x60001E9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001EA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001EC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C6720", Offset = "0x21C5B20", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001EB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001E8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004C")]
	private sealed class <FadeLandingNextStage>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000114")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000115")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000116")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000117")]
		private YieldInstruction <twait>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000118")]
		private InGameManager <gm>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000119")]
		private float <ttime>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400011A")]
		private Color <tcolor>5__5; //Field offset: 0x3C

		[Token(Token = "0x17000068")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001F0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000069")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001F2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001ED")]
		public <FadeLandingNextStage>d__35(int <>1__state) { }

		[Address(RVA = "0x21C6760", Offset = "0x21C5B60", Length = "0x27C")]
		[Token(Token = "0x60001EF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001F0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001F2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C69E0", Offset = "0x21C5DE0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001F1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001EE")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private sealed class <FinishInGameStage>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011D")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400011E")]
		public bool withNext; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400011F")]
		private InGameManager <gm>5__2; //Field offset: 0x30

		[Token(Token = "0x1700006A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001F6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700006B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001F8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001F3")]
		public <FinishInGameStage>d__21(int <>1__state) { }

		[Address(RVA = "0x21C6A20", Offset = "0x21C5E20", Length = "0x340")]
		[Token(Token = "0x60001F5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001F6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001F8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C6D80", Offset = "0x21C6180", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001F7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001F4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private sealed class <IntializeInGameMode>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000120")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000121")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000122")]
		public AssetReference _resident; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000123")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000124")]
		public Transform _root; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000125")]
		private InGameManager <gm>5__2; //Field offset: 0x38

		[Token(Token = "0x1700006C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001FC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700006D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001FE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001F9")]
		public <IntializeInGameMode>d__3(int <>1__state) { }

		[Address(RVA = "0x21C6FE0", Offset = "0x21C63E0", Length = "0x29E")]
		[Token(Token = "0x60001FB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001FC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001FE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C7280", Offset = "0x21C6680", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001FD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001FA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private sealed class <LoadResidentData>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000126")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000127")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000128")]
		public AssetReference _asr; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000129")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400012A")]
		public Transform _root; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400012B")]
		private AsyncInstantiateOperation<GameObject> <op>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400012C")]
		private InGameResident <tresindet>5__3; //Field offset: 0x40

		[Token(Token = "0x1700006E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000202")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700006F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000204")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001FF")]
		public <LoadResidentData>d__2(int <>1__state) { }

		[Address(RVA = "0x21C72C0", Offset = "0x21C66C0", Length = "0x376")]
		[Token(Token = "0x6000201")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000202")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000204")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C7640", Offset = "0x21C6A40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000203")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000200")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000050")]
	private sealed class <LoadStageAsset>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012F")]
		public AssetReference nstage; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000130")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000131")]
		private NowLoadingScope <>7__wrap1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000132")]
		private InGameManager <gm>5__3; //Field offset: 0x38

		[Token(Token = "0x17000070")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000209")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000071")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600020B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000205")]
		public <LoadStageAsset>d__1(int <>1__state) { }

		[Address(RVA = "0x21C7EB0", Offset = "0x21C72B0", Length = "0x50")]
		[Token(Token = "0x6000208")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21C7680", Offset = "0x21C6A80", Length = "0x738")]
		[Token(Token = "0x6000207")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000209")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600020B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C7DE0", Offset = "0x21C71E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600020A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21C7E20", Offset = "0x21C7220", Length = "0x8E")]
		[DebuggerHidden]
		[Token(Token = "0x6000206")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private sealed class <PlayLandingMovie>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000133")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000134")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000135")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000136")]
		public ArmsKind akind; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000137")]
		public int alevel; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000138")]
		private YieldInstruction <twait>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000139")]
		private float <playtime>5__3; //Field offset: 0x38

		[Token(Token = "0x17000072")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600020F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000073")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000211")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600020C")]
		public <PlayLandingMovie>d__29(int <>1__state) { }

		[Address(RVA = "0x21C8350", Offset = "0x21C7750", Length = "0x5C4")]
		[Token(Token = "0x600020E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600020F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000211")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C8930", Offset = "0x21C7D30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000210")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600020D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000052")]
	private sealed class <PlayTakeoffMovie>d__26 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400013B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400013C")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400013D")]
		private <>c__DisplayClass26_0 <>8__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400013E")]
		public CancellationToken _token; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400013F")]
		private SoundUtility <su>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000140")]
		private BGM <tbgm>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000141")]
		private YieldInstruction <twait>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000142")]
		private float <ttime>5__5; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000143")]
		private float <timepassed>5__6; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000144")]
		private bool <startPlayer>5__7; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000145")]
		private Color <tcolor>5__8; //Field offset: 0x5C

		[Token(Token = "0x17000074")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000215")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000075")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000217")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000212")]
		public <PlayTakeoffMovie>d__26(int <>1__state) { }

		[Address(RVA = "0x21C8970", Offset = "0x21C7D70", Length = "0x888")]
		[Token(Token = "0x6000214")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000215")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000217")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C9220", Offset = "0x21C8620", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000216")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000213")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private sealed class <SetPlayMovie>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000146")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000147")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000148")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000149")]
		public string tmovieName; //Field offset: 0x28

		[Token(Token = "0x17000076")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600021B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000077")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600021D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000218")]
		public <SetPlayMovie>d__25(int <>1__state) { }

		[Address(RVA = "0x21C9950", Offset = "0x21C8D50", Length = "0xE5")]
		[Token(Token = "0x600021A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600021B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600021D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C9A40", Offset = "0x21C8E40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600021C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000219")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <SetupGameSetting>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400014A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400014C")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400014D")]
		public bool skipReset; //Field offset: 0x28

		[Token(Token = "0x17000078")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000221")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000079")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000223")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600021E")]
		public <SetupGameSetting>d__18(int <>1__state) { }

		[Address(RVA = "0x21C9A80", Offset = "0x21C8E80", Length = "0x135")]
		[Token(Token = "0x6000220")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000221")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000223")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C9BC0", Offset = "0x21C8FC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000222")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600021F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private sealed class <SetupStage>d__47 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400014E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000150")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700007A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000227")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700007B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000229")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000224")]
		public <SetupStage>d__47(int <>1__state) { }

		[Address(RVA = "0x21C9DC0", Offset = "0x21C91C0", Length = "0xE6")]
		[Token(Token = "0x6000226")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000227")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000229")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C9EB0", Offset = "0x21C92B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000228")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000225")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000056")]
	private sealed class <StageResultPopup>d__49 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000151")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000152")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000153")]
		public StageInformation sinfo; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000154")]
		public PlayerInformation pinfo; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000155")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000156")]
		private <>c__DisplayClass49_0 <>8__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000157")]
		public Action waitcallBack; //Field offset: 0x40

		[Token(Token = "0x1700007C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600022D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700007D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600022F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600022A")]
		public <StageResultPopup>d__49(int <>1__state) { }

		[Address(RVA = "0x21C9EF0", Offset = "0x21C92F0", Length = "0x4C8")]
		[Token(Token = "0x600022C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600022D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600022F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21CA3E0", Offset = "0x21C97E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600022E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600022B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private sealed class <StartPlayer>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000158")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000159")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400015A")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400015B")]
		public CancellationToken _token; //Field offset: 0x28

		[Token(Token = "0x1700007E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000233")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700007F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000235")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000230")]
		public <StartPlayer>d__23(int <>1__state) { }

		[Address(RVA = "0x21CA840", Offset = "0x21C9C40", Length = "0x111")]
		[Token(Token = "0x6000232")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000233")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000235")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21CA960", Offset = "0x21C9D60", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000234")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000231")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private sealed class <StartPlayer>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400015D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400015E")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000080")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000239")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000081")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600023B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000236")]
		public <StartPlayer>d__34(int <>1__state) { }

		[Address(RVA = "0x21CAC70", Offset = "0x21CA070", Length = "0x174")]
		[Token(Token = "0x6000238")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000239")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600023B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21CADF0", Offset = "0x21CA1F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600023A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000237")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000059")]
	private sealed class <StartStage>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000160")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000161")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000162")]
		public CancellationToken _token; //Field offset: 0x28

		[Token(Token = "0x17000082")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600023F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000083")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000241")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600023C")]
		public <StartStage>d__22(int <>1__state) { }

		[Address(RVA = "0x21CAE30", Offset = "0x21CA230", Length = "0x13E")]
		[Token(Token = "0x600023E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600023F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000241")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21CAF70", Offset = "0x21CA370", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000240")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600023D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private sealed class <TerminateInGameMode>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000163")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000164")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000165")]
		public ModelGamePlayBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000084")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000245")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000085")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000247")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000242")]
		public <TerminateInGameMode>d__19(int <>1__state) { }

		[Address(RVA = "0x21CB510", Offset = "0x21CA910", Length = "0x250")]
		[Token(Token = "0x6000244")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000245")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000247")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21CB770", Offset = "0x21CAB70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000246")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000243")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000E8")]
	private static readonly String[] _openingMovies; //Field offset: 0x0
	[Token(Token = "0x40000E9")]
	private static readonly String[] _landingMovies; //Field offset: 0x8
	[Token(Token = "0x40000EA")]
	private static readonly String[] _landingMoviesA1; //Field offset: 0x10
	[Token(Token = "0x40000EB")]
	private static readonly String[] _landingMoviesA2; //Field offset: 0x18
	[Token(Token = "0x40000EC")]
	private static readonly String[] _landingMoviesDLC1; //Field offset: 0x20
	[Token(Token = "0x40000ED")]
	private static readonly String[] _landingMoviesDLC2; //Field offset: 0x28
	[Token(Token = "0x40000EE")]
	private static readonly String[] _landingMoviesDLC3; //Field offset: 0x30
	[Token(Token = "0x4000101")]
	private static readonly String[] playerBaseNames; //Field offset: 0x38
	[Token(Token = "0x4000102")]
	private static readonly int PlayerBaseNameCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EF")]
	protected bool _isError; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000F0")]
	protected bool _isStartOver; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40000F1")]
	protected bool _isChangingNextStage; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40000F2")]
	private bool _isRoundLoop; //Field offset: 0x13
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F3")]
	protected InGameStage _ingame; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F4")]
	protected InGameViewUI _stageUI; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F5")]
	protected PlayerControll _player; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F6")]
	private PlayerControll _player2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000F7")]
	protected TXEMoviePlayer _moviePlayer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000F8")]
	private RawImage _movieRawImage; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000F9")]
	private int _movieSeChannel; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000FA")]
	private AssetReferenceTable _stageTables; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000FB")]
	protected AssetReference _currentStage; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000FC")]
	protected int _stageCounts; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000FD")]
	protected int _stageIndex; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000FE")]
	protected int _clearStageCount; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000FF")]
	protected int _stageRound; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000100")]
	private Int32[] _playerIndexes; //Field offset: 0x70

	[Token(Token = "0x17000060")]
	public InGameStage GameStage
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001CF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	public bool IsChangingNext
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x60001CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005C")]
	public bool IsError
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005F")]
	protected bool IsRoundLoop
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x60001CE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005D")]
	public bool IsStartOver
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000061")]
	public int StageRound
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x60001D0")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x21C1750", Offset = "0x21C0B50", Length = "0xAD1")]
	[Token(Token = "0x60001D6")]
	private static ModelGamePlayBase() { }

	[Address(RVA = "0x21C2230", Offset = "0x21C1630", Length = "0x5C")]
	[Token(Token = "0x60001D5")]
	protected ModelGamePlayBase() { }

	[Address(RVA = "0x21BFC60", Offset = "0x21BF060", Length = "0x67")]
	[IteratorStateMachine(typeof(<CreateAndStartPlayer>d__31))]
	[Token(Token = "0x60001B8")]
	protected IEnumerator CreateAndStartPlayer() { }

	[Address(RVA = "0x21BFCD0", Offset = "0x21BF0D0", Length = "0x67")]
	[IteratorStateMachine(typeof(<CreateOnlyPlayer>d__32))]
	[Token(Token = "0x60001B9")]
	protected IEnumerator CreateOnlyPlayer() { }

	[Address(RVA = "0x21BFF00", Offset = "0x21BF300", Length = "0x67")]
	[IteratorStateMachine(typeof(<CreatePlayer>d__33))]
	[Token(Token = "0x60001BA")]
	protected override IEnumerator CreatePlayer() { }

	[Address(RVA = "0x21BFD40", Offset = "0x21BF140", Length = "0x1B8")]
	[Token(Token = "0x60001D3")]
	private Dictionary<String, Int32> CreatePlayerDictionary() { }

	[Address(RVA = "0x21BFF70", Offset = "0x21BF370", Length = "0x67")]
	[IteratorStateMachine(typeof(<FadeLandingNextStage>d__35))]
	[Token(Token = "0x60001BC")]
	protected IEnumerator FadeLandingNextStage() { }

	[Address(RVA = "0x21BFFE0", Offset = "0x21BF3E0", Length = "0x78")]
	[IteratorStateMachine(typeof(<FinishInGameStage>d__21))]
	[Token(Token = "0x60001AE")]
	protected IEnumerator FinishInGameStage(bool withNext) { }

	[Address(RVA = "0x21C0060", Offset = "0x21BF460", Length = "0x3B")]
	[Token(Token = "0x60001BE")]
	protected void FinishMoviePlayer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60001CF")]
	public InGameStage get_GameStage() { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x60001CD")]
	public bool get_IsChangingNext() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60001CB")]
	public bool get_IsError() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x60001CE")]
	protected bool get_IsRoundLoop() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x60001CC")]
	public bool get_IsStartOver() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x60001D0")]
	public int get_StageRound() { }

	[Address(RVA = "0x21C00A0", Offset = "0x21BF4A0", Length = "0x54")]
	[Token(Token = "0x60001A1")]
	protected override int GetBGMSetting() { }

	[Address(RVA = "0x21C0100", Offset = "0x21BF500", Length = "0x6A")]
	[Token(Token = "0x60001A3")]
	protected override int GetBomberCount() { }

	[Address(RVA = "0x21C0170", Offset = "0x21BF570", Length = "0x72")]
	[Token(Token = "0x60001A4")]
	protected override float GetDamageMag() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600019D")]
	protected override long GetHighScore() { }

	[Address(RVA = "0x21C01F0", Offset = "0x21BF5F0", Length = "0x1EA")]
	[Token(Token = "0x60001C0")]
	public static string GetLandingMovieName(ArmsKind akind, int alevel, int tkind) { }

	[Address(RVA = "0x21C03E0", Offset = "0x21BF7E0", Length = "0x82")]
	[Token(Token = "0x60001BF")]
	protected string GetOpeningMovieName(int tkind) { }

	[Address(RVA = "0x21C0470", Offset = "0x21BF870", Length = "0x75")]
	[Token(Token = "0x60001A0")]
	protected override PlayActor GetPlayActor() { }

	[Address(RVA = "0x21C0570", Offset = "0x21BF970", Length = "0x6B")]
	[Token(Token = "0x60001A2")]
	protected override int GetPlayerCount() { }

	[Address(RVA = "0x21C0660", Offset = "0x21BFA60", Length = "0x7F")]
	[Token(Token = "0x60001D4")]
	public static string GetPlayerModelString(int n) { }

	[Address(RVA = "0x21C05E0", Offset = "0x21BF9E0", Length = "0x71")]
	[Token(Token = "0x60001D1")]
	private string GetPlayerModelStringByIndex(int n) { }

	[Address(RVA = "0x21C04F0", Offset = "0x21BF8F0", Length = "0x75")]
	[Token(Token = "0x600019F")]
	protected override PlayMode GetPlayMode() { }

	[Address(RVA = "0x21C06E0", Offset = "0x21BFAE0", Length = "0xA1")]
	[IteratorStateMachine(typeof(<IntializeInGameMode>d__3))]
	[Token(Token = "0x600019C")]
	public override IEnumerator IntializeInGameMode(Transform _root, AssetReference _resident) { }

	[Address(RVA = "0x21C0790", Offset = "0x21BFB90", Length = "0x54")]
	[Token(Token = "0x60001A7")]
	protected override bool IsAutoBomber() { }

	[Address(RVA = "0x21C07F0", Offset = "0x21BFBF0", Length = "0x5A")]
	[Token(Token = "0x60001A9")]
	protected override bool IsEnableBlack() { }

	[Address(RVA = "0x21C0850", Offset = "0x21BFC50", Length = "0x5A")]
	[Token(Token = "0x60001AA")]
	protected override bool IsEnableGold() { }

	[Address(RVA = "0x21C08B0", Offset = "0x21BFCB0", Length = "0x31")]
	[Token(Token = "0x600019E")]
	private bool IsEneXChange() { }

	[Address(RVA = "0x21C08F0", Offset = "0x21BFCF0", Length = "0x16")]
	[Token(Token = "0x60001D2")]
	protected bool IsFirstPlayStage() { }

	[Address(RVA = "0x21C0910", Offset = "0x21BFD10", Length = "0x8")]
	[Token(Token = "0x60001B5")]
	public override bool IsMuteStart() { }

	[Address(RVA = "0x21C0920", Offset = "0x21BFD20", Length = "0xDD")]
	[Token(Token = "0x60001C5")]
	protected bool IsNextByClear() { }

	[Address(RVA = "0x21C0A00", Offset = "0x21BFE00", Length = "0x9D")]
	[Token(Token = "0x60001B7")]
	protected override bool IsSkipRequestMovie() { }

	[Address(RVA = "0x21C0AA0", Offset = "0x21BFEA0", Length = "0x71")]
	[Token(Token = "0x60001B4")]
	public override bool IsSkipTakeOffMovie() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001CA")]
	protected override bool IsTeamDouble() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001C9")]
	protected override bool IsTeamMode() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001A8")]
	protected override bool IsTrainig() { }

	[Address(RVA = "0x21C0B20", Offset = "0x21BFF20", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadResidentData>d__2))]
	[Token(Token = "0x600019B")]
	private IEnumerator LoadResidentData(Transform _root, AssetReference _asr) { }

	[Address(RVA = "0x21C0BD0", Offset = "0x21BFFD0", Length = "0x84")]
	[IteratorStateMachine(typeof(<LoadStageAsset>d__1))]
	[Token(Token = "0x600019A")]
	protected IEnumerator LoadStageAsset(AssetReference nstage) { }

	[Address(RVA = "0x21C0C60", Offset = "0x21C0060", Length = "0xAE")]
	[Token(Token = "0x60001A5")]
	protected override int P1FighterType() { }

	[Address(RVA = "0x21C0D10", Offset = "0x21C0110", Length = "0xAE")]
	[Token(Token = "0x60001A6")]
	protected override int P2FighterType() { }

	[Address(RVA = "0x21C0DC0", Offset = "0x21C01C0", Length = "0x86")]
	[IteratorStateMachine(typeof(<PlayLandingMovie>d__29))]
	[Token(Token = "0x60001B6")]
	protected IEnumerator PlayLandingMovie(ArmsKind akind, int alevel) { }

	[Address(RVA = "0x21C0E50", Offset = "0x21C0250", Length = "0x83")]
	[IteratorStateMachine(typeof(<PlayTakeoffMovie>d__26))]
	[Token(Token = "0x60001B3")]
	public override IEnumerator PlayTakeoffMovie(CancellationToken _token) { }

	[Address(RVA = "0x21C0EE0", Offset = "0x21C02E0", Length = "0xEF")]
	[Token(Token = "0x60001AD")]
	protected void RemovePlayers() { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60001C7")]
	public void SetCurrentStage(AssetReference tstage) { }

	[Address(RVA = "0x21C0FD0", Offset = "0x21C03D0", Length = "0xBB")]
	[Token(Token = "0x60001B1")]
	public void SetMoviePlayer(TXEMoviePlayer _movie, RawImage _raw) { }

	[Address(RVA = "0x21C1090", Offset = "0x21C0490", Length = "0x84")]
	[IteratorStateMachine(typeof(<SetPlayMovie>d__25))]
	[Token(Token = "0x60001B2")]
	protected IEnumerator SetPlayMovie(string tmovieName) { }

	[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
	[Token(Token = "0x60001C2")]
	public void SetRoundLoop(bool isLoop) { }

	[Address(RVA = "0x21C1130", Offset = "0x21C0530", Length = "0x92")]
	[Token(Token = "0x60001C4")]
	protected void SetStageTables(AssetReferenceTable stages) { }

	[Address(RVA = "0x21C11D0", Offset = "0x21C05D0", Length = "0x4E")]
	[Token(Token = "0x60001C6")]
	public void SetStartIndex(int tindex, int tround = 0) { }

	[Address(RVA = "0x21C1220", Offset = "0x21C0620", Length = "0x89")]
	[Token(Token = "0x60001C8")]
	public void SetStartOver(bool isSO) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000199")]
	public void SetUI(InGameViewUI _ui) { }

	[Address(RVA = "0x21C12B0", Offset = "0x21C06B0", Length = "0x78")]
	[IteratorStateMachine(typeof(<SetupGameSetting>d__18))]
	[Token(Token = "0x60001AB")]
	public IEnumerator SetupGameSetting(bool skipReset) { }

	[Address(RVA = "0x21C1330", Offset = "0x21C0730", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupStage>d__47))]
	[Token(Token = "0x60001C1")]
	public IEnumerator SetupStage() { }

	[Address(RVA = "0x21C13A0", Offset = "0x21C07A0", Length = "0xC0")]
	[IteratorStateMachine(typeof(<StageResultPopup>d__49))]
	[Token(Token = "0x60001C3")]
	protected IEnumerator StageResultPopup(StageInformation sinfo, PlayerInformation pinfo, Action waitcallBack = null) { }

	[Address(RVA = "0x21C14F0", Offset = "0x21C08F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<StartPlayer>d__34))]
	[Token(Token = "0x60001BB")]
	protected override IEnumerator StartPlayer() { }

	[Address(RVA = "0x21C1460", Offset = "0x21C0860", Length = "0x83")]
	[IteratorStateMachine(typeof(<StartPlayer>d__23))]
	[Token(Token = "0x60001B0")]
	public IEnumerator StartPlayer(CancellationToken _token) { }

	[Address(RVA = "0x21C1560", Offset = "0x21C0960", Length = "0x83")]
	[IteratorStateMachine(typeof(<StartStage>d__22))]
	[Token(Token = "0x60001AF")]
	public override IEnumerator StartStage(CancellationToken _token) { }

	[Address(RVA = "0x21C15F0", Offset = "0x21C09F0", Length = "0xEA")]
	[Token(Token = "0x60001BD")]
	protected void StopMoviePlayer() { }

	[Address(RVA = "0x21C16E0", Offset = "0x21C0AE0", Length = "0x67")]
	[IteratorStateMachine(typeof(<TerminateInGameMode>d__19))]
	[Token(Token = "0x60001AC")]
	public IEnumerator TerminateInGameMode() { }

}

