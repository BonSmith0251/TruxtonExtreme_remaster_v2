namespace TXEKernel;

[Token(Token = "0x2000057")]
public class PlayedRecords
{
	[CompilerGenerated]
	[Token(Token = "0x2000081")]
	private sealed class <Initialize>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000302")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000303")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000304")]
		public PlayedRecords <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700018A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000492")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700018B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000494")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600048F")]
		public <Initialize>d__2(int <>1__state) { }

		[Address(RVA = "0x2704E70", Offset = "0x2704270", Length = "0x184")]
		[Token(Token = "0x6000491")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000492")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000494")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2705010", Offset = "0x2704410", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000493")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000490")]
		private override void System.IDisposable.Dispose() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x2000059")]
	internal class Achievement : RecordsBase
	{
		[CompilerGenerated]
		[Token(Token = "0x200005B")]
		private sealed class <_allEnumerator>d__2 : IEnumerable<UnlockedDateTime>, IEnumerable, IEnumerator<UnlockedDateTime>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400023B")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400023C")]
			private UnlockedDateTime <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400023D")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400023E")]
			public Achievement <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400023F")]
			private Enumerator<UnlockedDateTime> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x170000BC")]
			private override UnlockedDateTime System.Collections.Generic.IEnumerator<TXEKernel.UnlockedDateTime>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60002CC")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000BD")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60002CE")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x60002C8")]
			public <_allEnumerator>d__2(int <>1__state) { }

			[Address(RVA = "0x2706C00", Offset = "0x2706000", Length = "0x41")]
			[Token(Token = "0x60002CB")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x27068E0", Offset = "0x2705CE0", Length = "0x1A9")]
			[Token(Token = "0x60002CA")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2706A90", Offset = "0x2705E90", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x60002CF")]
			private override IEnumerator<UnlockedDateTime> System.Collections.Generic.IEnumerable<TXEKernel.UnlockedDateTime>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60002CC")]
			private override UnlockedDateTime System.Collections.Generic.IEnumerator<TXEKernel.UnlockedDateTime>.get_Current() { }

			[Address(RVA = "0x2706A90", Offset = "0x2705E90", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x60002D0")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60002CE")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2706B30", Offset = "0x2705F30", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60002CD")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2706B70", Offset = "0x2705F70", Length = "0x83")]
			[DebuggerHidden]
			[Token(Token = "0x60002C9")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005A")]
		private sealed class <AllEnumerator>d__3 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000236")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000237")]
			private RecordValueBase <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000238")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000239")]
			public Achievement <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400023A")]
			private IEnumerator<UnlockedDateTime> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x170000BA")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60002C3")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000BB")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60002C5")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x60002BF")]
			public <AllEnumerator>d__3(int <>1__state) { }

			[Address(RVA = "0x2703BD0", Offset = "0x2702FD0", Length = "0x50")]
			[Token(Token = "0x60002C2")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2703810", Offset = "0x2702C10", Length = "0x241")]
			[Token(Token = "0x60002C1")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2703A60", Offset = "0x2702E60", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x60002C6")]
			private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60002C3")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

			[Address(RVA = "0x2703A60", Offset = "0x2702E60", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x60002C7")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60002C5")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2703B00", Offset = "0x2702F00", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60002C4")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2703B40", Offset = "0x2702F40", Length = "0x8C")]
			[DebuggerHidden]
			[Token(Token = "0x60002C0")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x4000234")]
		private const string _baseName = "Achievement"; //Field offset: 0x0
		[Token(Token = "0x4000235")]
		private const int _version_now = 100; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000232")]
		private readonly UnlockedDateTimeParams[] recordDateTimeParams; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000233")]
		private List<UnlockedDateTime> _records; //Field offset: 0x20

		[Token(Token = "0x170000B7")]
		private UnlockedDateTime Arcade
		{
			[Address(RVA = "0x26EBFE0", Offset = "0x26EB3E0", Length = "0x49")]
			[Token(Token = "0x60002BC")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B6")]
		private UnlockedDateTime Arena
		{
			[Address(RVA = "0x26EC030", Offset = "0x26EB430", Length = "0x49")]
			[Token(Token = "0x60002BB")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000AB")]
		private UnlockedDateTime Aserga
		{
			[Address(RVA = "0x26EC080", Offset = "0x26EB480", Length = "0x49")]
			[Token(Token = "0x60002B0")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B0")]
		private UnlockedDateTime Barley
		{
			[Address(RVA = "0x26EC0D0", Offset = "0x26EB4D0", Length = "0x49")]
			[Token(Token = "0x60002B5")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B8")]
		protected virtual string BaseName
		{
			[Address(RVA = "0x26EC120", Offset = "0x26EB520", Length = "0x2C")]
			[Token(Token = "0x60002BD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000A9")]
		private UnlockedDateTime Doguraba
		{
			[Address(RVA = "0x26EC150", Offset = "0x26EB550", Length = "0x49")]
			[Token(Token = "0x60002AE")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B1")]
		private UnlockedDateTime EpisodeAsh
		{
			[Address(RVA = "0x26EC1A0", Offset = "0x26EB5A0", Length = "0x49")]
			[Token(Token = "0x60002B6")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B2")]
		private UnlockedDateTime EpisodeBelgamt
		{
			[Address(RVA = "0x26EC1F0", Offset = "0x26EB5F0", Length = "0x49")]
			[Token(Token = "0x60002B7")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B3")]
		private UnlockedDateTime EpisodeChria
		{
			[Address(RVA = "0x26EC240", Offset = "0x26EB640", Length = "0x49")]
			[Token(Token = "0x60002B8")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000A6")]
		private UnlockedDateTime ExtremePlayer
		{
			[Address(RVA = "0x26EC290", Offset = "0x26EB690", Length = "0x46")]
			[Token(Token = "0x60002AB")]
			private get { } //Length: 70
		}

		[Token(Token = "0x170000AF")]
		private UnlockedDateTime Gashim
		{
			[Address(RVA = "0x26EC2E0", Offset = "0x26EB6E0", Length = "0x49")]
			[Token(Token = "0x60002B4")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000AD")]
		private UnlockedDateTime Guamy
		{
			[Address(RVA = "0x26EC330", Offset = "0x26EB730", Length = "0x49")]
			[Token(Token = "0x60002B2")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000A8")]
		private UnlockedDateTime Initialized
		{
			[Address(RVA = "0x26EC380", Offset = "0x26EB780", Length = "0x49")]
			[Token(Token = "0x60002AD")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000AC")]
		private UnlockedDateTime Ipan
		{
			[Address(RVA = "0x26EC3D0", Offset = "0x26EB7D0", Length = "0x49")]
			[Token(Token = "0x60002B1")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000A5")]
		public UnlockedDateTime Item
		{
			[Address(RVA = "0x26EC420", Offset = "0x26EB820", Length = "0x51")]
			[Token(Token = "0x60002AA")]
			 get { } //Length: 81
		}

		[Token(Token = "0x170000B4")]
		private UnlockedDateTime Pipiru
		{
			[Address(RVA = "0x26EC480", Offset = "0x26EB880", Length = "0x49")]
			[Token(Token = "0x60002B9")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000A4")]
		public List<UnlockedDateTime> Records
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60002A9")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000AE")]
		private UnlockedDateTime Sama
		{
			[Address(RVA = "0x26EC4D0", Offset = "0x26EB8D0", Length = "0x49")]
			[Token(Token = "0x60002B3")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000AA")]
		private UnlockedDateTime Soroo
		{
			[Address(RVA = "0x26EC520", Offset = "0x26EB920", Length = "0x49")]
			[Token(Token = "0x60002AF")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B5")]
		private UnlockedDateTime Team
		{
			[Address(RVA = "0x26EC570", Offset = "0x26EB970", Length = "0x49")]
			[Token(Token = "0x60002BA")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000B9")]
		public virtual int Version_now
		{
			[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
			[Token(Token = "0x60002BE")]
			 get { } //Length: 6
		}

		[Token(Token = "0x170000A7")]
		private UnlockedDateTime Welcome
		{
			[Address(RVA = "0x26EC5C0", Offset = "0x26EB9C0", Length = "0x49")]
			[Token(Token = "0x60002AC")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x26EB1B0", Offset = "0x26EA5B0", Length = "0x71")]
		[IteratorStateMachine(typeof(<_allEnumerator>d__2))]
		[Token(Token = "0x60002A1")]
		private IEnumerable<UnlockedDateTime> _allEnumerator() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002A4")]
		protected virtual void _postMigrate() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002A3")]
		protected virtual void _preMigrate() { }

		[Address(RVA = "0x26EB230", Offset = "0x26EA630", Length = "0xDA7")]
		[Token(Token = "0x60002A0")]
		public Achievement() { }

		[Address(RVA = "0x26EAF10", Offset = "0x26EA310", Length = "0x71")]
		[IteratorStateMachine(typeof(<AllEnumerator>d__3))]
		[Token(Token = "0x60002A2")]
		protected virtual IEnumerable<RecordValueBase> AllEnumerator() { }

		[Address(RVA = "0x26EAF90", Offset = "0x26EA390", Length = "0x60")]
		[Token(Token = "0x60002A5")]
		public DateTime DateTime(ID idx) { }

		[Address(RVA = "0x26EBFE0", Offset = "0x26EB3E0", Length = "0x49")]
		[Token(Token = "0x60002BC")]
		private UnlockedDateTime get_Arcade() { }

		[Address(RVA = "0x26EC030", Offset = "0x26EB430", Length = "0x49")]
		[Token(Token = "0x60002BB")]
		private UnlockedDateTime get_Arena() { }

		[Address(RVA = "0x26EC080", Offset = "0x26EB480", Length = "0x49")]
		[Token(Token = "0x60002B0")]
		private UnlockedDateTime get_Aserga() { }

		[Address(RVA = "0x26EC0D0", Offset = "0x26EB4D0", Length = "0x49")]
		[Token(Token = "0x60002B5")]
		private UnlockedDateTime get_Barley() { }

		[Address(RVA = "0x26EC120", Offset = "0x26EB520", Length = "0x2C")]
		[Token(Token = "0x60002BD")]
		protected virtual string get_BaseName() { }

		[Address(RVA = "0x26EC150", Offset = "0x26EB550", Length = "0x49")]
		[Token(Token = "0x60002AE")]
		private UnlockedDateTime get_Doguraba() { }

		[Address(RVA = "0x26EC1A0", Offset = "0x26EB5A0", Length = "0x49")]
		[Token(Token = "0x60002B6")]
		private UnlockedDateTime get_EpisodeAsh() { }

		[Address(RVA = "0x26EC1F0", Offset = "0x26EB5F0", Length = "0x49")]
		[Token(Token = "0x60002B7")]
		private UnlockedDateTime get_EpisodeBelgamt() { }

		[Address(RVA = "0x26EC240", Offset = "0x26EB640", Length = "0x49")]
		[Token(Token = "0x60002B8")]
		private UnlockedDateTime get_EpisodeChria() { }

		[Address(RVA = "0x26EC290", Offset = "0x26EB690", Length = "0x46")]
		[Token(Token = "0x60002AB")]
		private UnlockedDateTime get_ExtremePlayer() { }

		[Address(RVA = "0x26EC2E0", Offset = "0x26EB6E0", Length = "0x49")]
		[Token(Token = "0x60002B4")]
		private UnlockedDateTime get_Gashim() { }

		[Address(RVA = "0x26EC330", Offset = "0x26EB730", Length = "0x49")]
		[Token(Token = "0x60002B2")]
		private UnlockedDateTime get_Guamy() { }

		[Address(RVA = "0x26EC380", Offset = "0x26EB780", Length = "0x49")]
		[Token(Token = "0x60002AD")]
		private UnlockedDateTime get_Initialized() { }

		[Address(RVA = "0x26EC3D0", Offset = "0x26EB7D0", Length = "0x49")]
		[Token(Token = "0x60002B1")]
		private UnlockedDateTime get_Ipan() { }

		[Address(RVA = "0x26EC420", Offset = "0x26EB820", Length = "0x51")]
		[Token(Token = "0x60002AA")]
		public UnlockedDateTime get_Item(ID idx) { }

		[Address(RVA = "0x26EC480", Offset = "0x26EB880", Length = "0x49")]
		[Token(Token = "0x60002B9")]
		private UnlockedDateTime get_Pipiru() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60002A9")]
		public List<UnlockedDateTime> get_Records() { }

		[Address(RVA = "0x26EC4D0", Offset = "0x26EB8D0", Length = "0x49")]
		[Token(Token = "0x60002B3")]
		private UnlockedDateTime get_Sama() { }

		[Address(RVA = "0x26EC520", Offset = "0x26EB920", Length = "0x49")]
		[Token(Token = "0x60002AF")]
		private UnlockedDateTime get_Soroo() { }

		[Address(RVA = "0x26EC570", Offset = "0x26EB970", Length = "0x49")]
		[Token(Token = "0x60002BA")]
		private UnlockedDateTime get_Team() { }

		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x60002BE")]
		public virtual int get_Version_now() { }

		[Address(RVA = "0x26EC5C0", Offset = "0x26EB9C0", Length = "0x49")]
		[Token(Token = "0x60002AC")]
		private UnlockedDateTime get_Welcome() { }

		[Address(RVA = "0x26EB000", Offset = "0x26EA400", Length = "0x60")]
		[Token(Token = "0x60002A6")]
		public bool IsUnlocked(ID idx) { }

		[Address(RVA = "0x26EB070", Offset = "0x26EA470", Length = "0x60")]
		[Token(Token = "0x60002A8")]
		public void Lock(ID idx, DateTime t) { }

		[Address(RVA = "0x26EB0E0", Offset = "0x26EA4E0", Length = "0xC7")]
		[Token(Token = "0x60002A7")]
		public void Unlock(ID idx, DateTime t) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x200005C")]
	internal class Enemies : RecordsBase
	{
		[CompilerGenerated]
		[Token(Token = "0x2000060")]
		private sealed class <__allEnumerator>d__7 : IEnumerable<KeyValuePair`2<String, Data>>, IEnumerable, IEnumerator<KeyValuePair`2<String, Data>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000257")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000258")]
			private KeyValuePair<String, Data> <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000259")]
			private int <>l__initialThreadId; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400025A")]
			public Enemies <>4__this; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x400025B")]
			private Enumerator<String, Data> <>7__wrap1; //Field offset: 0x38

			[Token(Token = "0x170000CC")]
			private override KeyValuePair<String, Data> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,TXEKernel.PlayedRecords.Enemies.Data>>.Current
			{
				[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
				[DebuggerHidden]
				[Token(Token = "0x6000309")]
				private get { } //Length: 11
			}

			[Token(Token = "0x170000CD")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x2705BA0", Offset = "0x2704FA0", Length = "0x45")]
				[DebuggerHidden]
				[Token(Token = "0x600030B")]
				private get { } //Length: 69
			}

			[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000305")]
			public <__allEnumerator>d__7(int <>1__state) { }

			[Address(RVA = "0x2705C80", Offset = "0x2705080", Length = "0x41")]
			[Token(Token = "0x6000308")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x27058F0", Offset = "0x2704CF0", Length = "0x1C7")]
			[Token(Token = "0x6000307")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2705AC0", Offset = "0x2704EC0", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600030C")]
			private override IEnumerator<KeyValuePair`2<String, Data>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TXEKernel.PlayedRecords.Enemies.Data>>.GetEnumerator() { }

			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000309")]
			private override KeyValuePair<String, Data> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,TXEKernel.PlayedRecords.Enemies.Data>>.get_Current() { }

			[Address(RVA = "0x2705AC0", Offset = "0x2704EC0", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600030D")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x2705BA0", Offset = "0x2704FA0", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x600030B")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2705B60", Offset = "0x2704F60", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x600030A")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2705BF0", Offset = "0x2704FF0", Length = "0x83")]
			[DebuggerHidden]
			[Token(Token = "0x6000306")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000061")]
		private sealed class <_allEnumerator>d__8 : IEnumerable<Data>, IEnumerable, IEnumerator<Data>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400025C")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400025D")]
			private Data <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400025E")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400025F")]
			public Enemies <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000260")]
			private IEnumerator<KeyValuePair`2<String, Data>> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x170000CE")]
			private override Data System.Collections.Generic.IEnumerator<TXEKernel.PlayedRecords.Enemies.Data>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000312")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000CF")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000314")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x600030E")]
			public <_allEnumerator>d__8(int <>1__state) { }

			[Address(RVA = "0x2707330", Offset = "0x2706730", Length = "0x50")]
			[Token(Token = "0x6000311")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2706FC0", Offset = "0x27063C0", Length = "0x1F7")]
			[Token(Token = "0x6000310")]
			private override bool MoveNext() { }

			[Address(RVA = "0x27071C0", Offset = "0x27065C0", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000315")]
			private override IEnumerator<Data> System.Collections.Generic.IEnumerable<TXEKernel.PlayedRecords.Enemies.Data>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000312")]
			private override Data System.Collections.Generic.IEnumerator<TXEKernel.PlayedRecords.Enemies.Data>.get_Current() { }

			[Address(RVA = "0x27071C0", Offset = "0x27065C0", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000316")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000314")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2707260", Offset = "0x2706660", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000313")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x27072A0", Offset = "0x27066A0", Length = "0x8C")]
			[DebuggerHidden]
			[Token(Token = "0x600030F")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000062")]
		private sealed class <_initialize>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000261")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000262")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000263")]
			public Enemies <>4__this; //Field offset: 0x20

			[Token(Token = "0x170000D0")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600031A")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000D1")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600031C")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x6000317")]
			public <_initialize>d__3(int <>1__state) { }

			[Address(RVA = "0x2707380", Offset = "0x2706780", Length = "0x1B7")]
			[Token(Token = "0x6000319")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600031A")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600031C")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2707540", Offset = "0x2706940", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x600031B")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000318")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005F")]
		private sealed class <AllEnumerator>d__9 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000251")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000252")]
			private RecordValueBase <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000253")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000254")]
			public Enemies <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000255")]
			private IEnumerator<Data> <>7__wrap1; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000256")]
			private IEnumerator<RecordValueBase> <>7__wrap2; //Field offset: 0x38

			[Token(Token = "0x170000CA")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000300")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000CB")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000302")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x60002FB")]
			public <AllEnumerator>d__9(int <>1__state) { }

			[Address(RVA = "0x2704AC0", Offset = "0x2703EC0", Length = "0x50")]
			[Token(Token = "0x60002FE")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2704B10", Offset = "0x2703F10", Length = "0x50")]
			[Token(Token = "0x60002FF")]
			private void <>m__Finally2() { }

			[Address(RVA = "0x2704510", Offset = "0x2703910", Length = "0x371")]
			[Token(Token = "0x60002FD")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2704890", Offset = "0x2703C90", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000303")]
			private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000300")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

			[Address(RVA = "0x2704890", Offset = "0x2703C90", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000304")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000302")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2704930", Offset = "0x2703D30", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000301")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2704970", Offset = "0x2703D70", Length = "0x14A")]
			[DebuggerHidden]
			[Token(Token = "0x60002FC")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x200005D")]
		internal class Data
		{
			[CompilerGenerated]
			[Token(Token = "0x200005E")]
			private sealed class <AllEnumerator>d__2 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x400024D")]
				private int <>1__state; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x400024E")]
				private RecordValueBase <>2__current; //Field offset: 0x18
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x400024F")]
				private int <>l__initialThreadId; //Field offset: 0x20
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x4000250")]
				public Data <>4__this; //Field offset: 0x28

				[Token(Token = "0x170000C8")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60002F6")]
					private get { } //Length: 5
				}

				[Token(Token = "0x170000C9")]
				private override object System.Collections.IEnumerator.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60002F8")]
					private get { } //Length: 5
				}

				[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
				[DebuggerHidden]
				[Token(Token = "0x60002F3")]
				public <AllEnumerator>d__2(int <>1__state) { }

				[Address(RVA = "0x2702530", Offset = "0x2701930", Length = "0xC3")]
				[Token(Token = "0x60002F5")]
				private override bool MoveNext() { }

				[Address(RVA = "0x2703080", Offset = "0x2702480", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x60002F9")]
				private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60002F6")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

				[Address(RVA = "0x2703080", Offset = "0x2702480", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x60002FA")]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60002F8")]
				private override object System.Collections.IEnumerator.get_Current() { }

				[Address(RVA = "0x2703380", Offset = "0x2702780", Length = "0x3E")]
				[DebuggerHidden]
				[Token(Token = "0x60002F7")]
				private override void System.Collections.IEnumerator.Reset() { }

				[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
				[DebuggerHidden]
				[Token(Token = "0x60002F4")]
				private override void System.IDisposable.Dispose() { }

			}

			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000246")]
			private RecordClampedInt64 _destroyCount; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000247")]
			private UnlockedDateTime _unlockedDateTime; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000248")]
			private RecordDateTime _viewed; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000249")]
			private bool _bossFlg; //Field offset: 0x28
			[FieldOffset(Offset = "0x29")]
			[Token(Token = "0x400024A")]
			private bool _isViewer; //Field offset: 0x29
			[FieldOffset(Offset = "0x2A")]
			[Token(Token = "0x400024B")]
			private bool _viewerOnlyFlg; //Field offset: 0x2A
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400024C")]
			private string _alias; //Field offset: 0x30

			[Token(Token = "0x170000C7")]
			public string Alias
			{
				[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
				[Token(Token = "0x60002F1")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170000C4")]
			public bool BossFlg
			{
				[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
				[Token(Token = "0x60002EE")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170000C2")]
			public long DestroyCount
			{
				[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
				[Token(Token = "0x60002E6")]
				 get { } //Length: 42
			}

			[Token(Token = "0x170000C5")]
			public bool IsViewer
			{
				[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
				[Token(Token = "0x60002EF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170000C3")]
			public DateTime UnlockedDateTime
			{
				[Address(RVA = "0x26F0AB0", Offset = "0x26EFEB0", Length = "0x1D")]
				[Token(Token = "0x60002E7")]
				 get { } //Length: 29
			}

			[Token(Token = "0x170000C6")]
			public bool ViewerOnlyFlg
			{
				[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
				[Token(Token = "0x60002F0")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x26F02D0", Offset = "0x26EF6D0", Length = "0x2DD")]
			[Token(Token = "0x60002E1")]
			public Data(string enemyId, bool bossFlg, bool isViewer, string alias) { }

			[Address(RVA = "0x26EFA70", Offset = "0x26EEE70", Length = "0x71")]
			[IteratorStateMachine(typeof(<AllEnumerator>d__2))]
			[Token(Token = "0x60002E3")]
			public IEnumerable<RecordValueBase> AllEnumerator() { }

			[Address(RVA = "0x26EFB70", Offset = "0x26EEF70", Length = "0x54")]
			[Token(Token = "0x60002E5")]
			public void CountCopy(Data d) { }

			[Address(RVA = "0x26EFBD0", Offset = "0x26EEFD0", Length = "0x5B")]
			[Token(Token = "0x60002E4")]
			public void CountUp(long v) { }

			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x60002F1")]
			public string get_Alias() { }

			[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
			[Token(Token = "0x60002EE")]
			public bool get_BossFlg() { }

			[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
			[Token(Token = "0x60002E6")]
			public long get_DestroyCount() { }

			[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
			[Token(Token = "0x60002EF")]
			public bool get_IsViewer() { }

			[Address(RVA = "0x26F0AB0", Offset = "0x26EFEB0", Length = "0x1D")]
			[Token(Token = "0x60002E7")]
			public DateTime get_UnlockedDateTime() { }

			[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
			[Token(Token = "0x60002F0")]
			public bool get_ViewerOnlyFlg() { }

			[Address(RVA = "0x26EFC30", Offset = "0x26EF030", Length = "0x1E")]
			[Token(Token = "0x60002F2")]
			public bool IsAlias() { }

			[Address(RVA = "0x26EFCB0", Offset = "0x26EF0B0", Length = "0x48")]
			[Token(Token = "0x60002ED")]
			public bool IsNew() { }

			[Address(RVA = "0x26EFD00", Offset = "0x26EF100", Length = "0x1D")]
			[Token(Token = "0x60002EA")]
			public bool IsUnlocked() { }

			[Address(RVA = "0x26EDD50", Offset = "0x26ED150", Length = "0x1D")]
			[Token(Token = "0x60002EC")]
			public bool IsViewed() { }

			[Address(RVA = "0x26EFD40", Offset = "0x26EF140", Length = "0x3D")]
			[Token(Token = "0x60002EB")]
			public void SetViewed() { }

			[Address(RVA = "0x26EFE00", Offset = "0x26EF200", Length = "0x1D")]
			[Token(Token = "0x60002E8")]
			public void Unlock() { }

			[Address(RVA = "0x26EFD80", Offset = "0x26EF180", Length = "0x76")]
			[Token(Token = "0x60002E9")]
			public void Unlock(DateTime unlockedDateTime) { }

			[Address(RVA = "0x26F01F0", Offset = "0x26EF5F0", Length = "0xD6")]
			[Token(Token = "0x60002E2")]
			public static Data ViewerOnlyData(string enemyId, bool bossFlg) { }

		}

		[Token(Token = "0x4000242")]
		private static readonly long DestroyValueMax; //Field offset: 0x0
		[Token(Token = "0x4000243")]
		private const string _baseName = "enemies"; //Field offset: 0x0
		[Token(Token = "0x4000245")]
		private const int _version_now = 100; //Field offset: 0x0
		[Token(Token = "0x4000244")]
		public static readonly string _enemyDatabasePath; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000240")]
		private Dictionary<String, Data> _records; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000241")]
		private String[] fixedEnemyId; //Field offset: 0x20

		[Token(Token = "0x170000C0")]
		protected virtual string BaseName
		{
			[Address(RVA = "0x26F2140", Offset = "0x26F1540", Length = "0x2C")]
			[Token(Token = "0x60002DE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000BF")]
		public Data Item
		{
			[Address(RVA = "0x26F2170", Offset = "0x26F1570", Length = "0x88")]
			[Token(Token = "0x60002DD")]
			 get { } //Length: 136
		}

		[Token(Token = "0x170000BE")]
		public Dictionary<String, Data> Records
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60002DC")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000C1")]
		public virtual int Version_now
		{
			[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
			[Token(Token = "0x60002DF")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x26F1DB0", Offset = "0x26F11B0", Length = "0x71")]
		[IteratorStateMachine(typeof(<__allEnumerator>d__7))]
		[Token(Token = "0x60002D7")]
		private IEnumerable<KeyValuePair`2<String, Data>> __allEnumerator() { }

		[Address(RVA = "0x26F1E30", Offset = "0x26F1230", Length = "0x71")]
		[IteratorStateMachine(typeof(<_allEnumerator>d__8))]
		[Token(Token = "0x60002D8")]
		private IEnumerable<Data> _allEnumerator() { }

		[Address(RVA = "0x26F20D0", Offset = "0x26F14D0", Length = "0x67")]
		[IteratorStateMachine(typeof(<_initialize>d__3))]
		[Token(Token = "0x60002D3")]
		public virtual IEnumerator _initialize() { }

		[Address(RVA = "0x26F1A00", Offset = "0x26F0E00", Length = "0x3A3")]
		[Token(Token = "0x60002D2")]
		private void _Initialize(EnemyDataBaseRecords enemyDB) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002DB")]
		protected virtual void _postMigrate() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002DA")]
		protected virtual void _preMigrate() { }

		[Address(RVA = "0x26F1EB0", Offset = "0x26F12B0", Length = "0x82")]
		[Token(Token = "0x60002E0")]
		private static Enemies() { }

		[Address(RVA = "0x26F1F40", Offset = "0x26F1340", Length = "0x18F")]
		[Token(Token = "0x60002D1")]
		public Enemies() { }

		[Address(RVA = "0x26F0B80", Offset = "0x26EFF80", Length = "0x71")]
		[IteratorStateMachine(typeof(<AllEnumerator>d__9))]
		[Token(Token = "0x60002D9")]
		protected virtual IEnumerable<RecordValueBase> AllEnumerator() { }

		[Address(RVA = "0x26F0C00", Offset = "0x26F0000", Length = "0x358")]
		[Token(Token = "0x60002D5")]
		public List<String> EvaluateRecords(DateTime unlockedDateTime) { }

		[Address(RVA = "0x26F2140", Offset = "0x26F1540", Length = "0x2C")]
		[Token(Token = "0x60002DE")]
		protected virtual string get_BaseName() { }

		[Address(RVA = "0x26F2170", Offset = "0x26F1570", Length = "0x88")]
		[Token(Token = "0x60002DD")]
		public Data get_Item(string enemyId) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002DC")]
		public Dictionary<String, Data> get_Records() { }

		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x60002DF")]
		public virtual int get_Version_now() { }

		[Address(RVA = "0x26F0F60", Offset = "0x26F0360", Length = "0x46C")]
		[Token(Token = "0x60002D6")]
		public bool IsNew() { }

		[Address(RVA = "0x26F13D0", Offset = "0x26F07D0", Length = "0x623")]
		[Token(Token = "0x60002D4")]
		public void Update(Dictionary<String, Int32> destroyed, UpdateParams stages) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x2000063")]
	internal class General : RecordsBase
	{
		[CompilerGenerated]
		[Token(Token = "0x2000066")]
		private sealed class <_allEnumerator>d__4 : IEnumerable<UnlockedDateTime>, IEnumerable, IEnumerator<UnlockedDateTime>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400027C")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400027D")]
			private UnlockedDateTime <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400027E")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400027F")]
			public General <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000280")]
			private Enumerator<UnlockedDateTime> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x170000F4")]
			private override UnlockedDateTime System.Collections.Generic.IEnumerator<TXEKernel.UnlockedDateTime>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600035A")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000F5")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600035C")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000356")]
			public <_allEnumerator>d__4(int <>1__state) { }

			[Address(RVA = "0x2706F70", Offset = "0x2706370", Length = "0x41")]
			[Token(Token = "0x6000359")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2706C50", Offset = "0x2706050", Length = "0x1A9")]
			[Token(Token = "0x6000358")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2706E00", Offset = "0x2706200", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600035D")]
			private override IEnumerator<UnlockedDateTime> System.Collections.Generic.IEnumerable<TXEKernel.UnlockedDateTime>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600035A")]
			private override UnlockedDateTime System.Collections.Generic.IEnumerator<TXEKernel.UnlockedDateTime>.get_Current() { }

			[Address(RVA = "0x2706E00", Offset = "0x2706200", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600035E")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600035C")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2706EA0", Offset = "0x27062A0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x600035B")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2706EE0", Offset = "0x27062E0", Length = "0x83")]
			[DebuggerHidden]
			[Token(Token = "0x6000357")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000065")]
		private sealed class <AllEnumerator>d__5 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000277")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000278")]
			private RecordValueBase <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000279")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400027A")]
			public General <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400027B")]
			private IEnumerator<UnlockedDateTime> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x170000F2")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000351")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170000F3")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000353")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x600034D")]
			public <AllEnumerator>d__5(int <>1__state) { }

			[Address(RVA = "0x2703FE0", Offset = "0x27033E0", Length = "0x50")]
			[Token(Token = "0x6000350")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2703C20", Offset = "0x2703020", Length = "0x241")]
			[Token(Token = "0x600034F")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2703E70", Offset = "0x2703270", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000354")]
			private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000351")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

			[Address(RVA = "0x2703E70", Offset = "0x2703270", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000355")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000353")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2703F10", Offset = "0x2703310", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000352")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2703F50", Offset = "0x2703350", Length = "0x8C")]
			[DebuggerHidden]
			[Token(Token = "0x600034E")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x2000064")]
		internal enum Label : int
		{
			GameSettingsPlayers10Unlocked = 0,
			GameSettingsAutoBombUnlocked = 1,
			GoldThunderLaserUnlocked = 2,
			GameSettingsBombsUnlocked = 3,
			WokeUpUnlocked = 4,
			BlackThunderLaserUnlocked = 5,
			GameSettingsPlayers100Unlocked = 6,
			GameSettingsPowerUnlocked = 7,
			MoreAwakeUnlocked = 8,
			PipiruPlanetUnlocked = 9,
			PipiruComicUnlocked = 10,
			ArcadeUnlocked = 11,
			ArenaUnlocked = 12,
			TrainingUnlocked = 13,
		}

		[Token(Token = "0x4000266")]
		private const string _baseName = "general"; //Field offset: 0x0
		[Token(Token = "0x4000267")]
		private const int _version_now = 100; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000264")]
		private readonly UnlockedDateTimeParams[] recordDateTimeParams; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000265")]
		private List<UnlockedDateTime> _records; //Field offset: 0x20

		[Token(Token = "0x170000DF")]
		private UnlockedDateTime ArcadeUnlocked
		{
			[Address(RVA = "0x26F41C0", Offset = "0x26F35C0", Length = "0x49")]
			[Token(Token = "0x6000330")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000E0")]
		private UnlockedDateTime ArenaUnlocked
		{
			[Address(RVA = "0x26F4210", Offset = "0x26F3610", Length = "0x49")]
			[Token(Token = "0x6000331")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000F0")]
		protected virtual string BaseName
		{
			[Address(RVA = "0x26F4260", Offset = "0x26F3660", Length = "0x2C")]
			[Token(Token = "0x600034B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000D9")]
		private UnlockedDateTime BlackThunderLaserUnlocked
		{
			[Address(RVA = "0x26F4290", Offset = "0x26F3690", Length = "0x49")]
			[Token(Token = "0x600032A")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000D5")]
		private UnlockedDateTime GameSettingsAutoBombUnlocked
		{
			[Address(RVA = "0x26F42E0", Offset = "0x26F36E0", Length = "0x49")]
			[Token(Token = "0x6000326")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000D7")]
		private UnlockedDateTime GameSettingsBombsUnlocked
		{
			[Address(RVA = "0x26F4330", Offset = "0x26F3730", Length = "0x49")]
			[Token(Token = "0x6000328")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000DA")]
		private UnlockedDateTime GameSettingsPlayers100Unlocked
		{
			[Address(RVA = "0x26F4380", Offset = "0x26F3780", Length = "0x49")]
			[Token(Token = "0x600032B")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000D4")]
		private UnlockedDateTime GameSettingsPlayers10Unlocked
		{
			[Address(RVA = "0x26F43D0", Offset = "0x26F37D0", Length = "0x46")]
			[Token(Token = "0x6000325")]
			private get { } //Length: 70
		}

		[Token(Token = "0x170000DB")]
		private UnlockedDateTime GameSettingsPowerUnlocked
		{
			[Address(RVA = "0x26F4420", Offset = "0x26F3820", Length = "0x49")]
			[Token(Token = "0x600032C")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000D6")]
		private UnlockedDateTime GoldThunderLaserUnlocked
		{
			[Address(RVA = "0x26F4470", Offset = "0x26F3870", Length = "0x49")]
			[Token(Token = "0x6000327")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000ED")]
		public bool IsArcadeUnlocked
		{
			[Address(RVA = "0x26F44C0", Offset = "0x26F38C0", Length = "0x58")]
			[Token(Token = "0x600033E")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000EE")]
		public bool IsArenaUnlocked
		{
			[Address(RVA = "0x26F4520", Offset = "0x26F3920", Length = "0x58")]
			[Token(Token = "0x600033F")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E7")]
		public bool IsBlackThunderLaserUnlocked
		{
			[Address(RVA = "0x26F4580", Offset = "0x26F3980", Length = "0x58")]
			[Token(Token = "0x6000338")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E3")]
		public bool IsGameSettingsAutoBombUnlocked
		{
			[Address(RVA = "0x26F45E0", Offset = "0x26F39E0", Length = "0x58")]
			[Token(Token = "0x6000334")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E5")]
		public bool IsGameSettingsBombsUnlocked
		{
			[Address(RVA = "0x26F4640", Offset = "0x26F3A40", Length = "0x58")]
			[Token(Token = "0x6000336")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E8")]
		public bool IsGameSettingsPlayers100Unlocked
		{
			[Address(RVA = "0x26F46A0", Offset = "0x26F3AA0", Length = "0x58")]
			[Token(Token = "0x6000339")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E2")]
		public bool IsGameSettingsPlayers10Unlocked
		{
			[Address(RVA = "0x26F4700", Offset = "0x26F3B00", Length = "0x55")]
			[Token(Token = "0x6000333")]
			 get { } //Length: 85
		}

		[Token(Token = "0x170000E9")]
		public bool IsGameSettingsPowerUnlocked
		{
			[Address(RVA = "0x26F4760", Offset = "0x26F3B60", Length = "0x58")]
			[Token(Token = "0x600033A")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E4")]
		public bool IsGoldThunderLaserUnlocked
		{
			[Address(RVA = "0x26F47C0", Offset = "0x26F3BC0", Length = "0x58")]
			[Token(Token = "0x6000335")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000EA")]
		public bool IsMoreAwakeUnlocked
		{
			[Address(RVA = "0x26F4820", Offset = "0x26F3C20", Length = "0x58")]
			[Token(Token = "0x600033B")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000EC")]
		public bool IsPipiruComicUnlocked
		{
			[Address(RVA = "0x26F4880", Offset = "0x26F3C80", Length = "0x58")]
			[Token(Token = "0x600033D")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000EB")]
		public bool IsPipiruPlanetUnlocked
		{
			[Address(RVA = "0x26F48E0", Offset = "0x26F3CE0", Length = "0x58")]
			[Token(Token = "0x600033C")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000EF")]
		public bool IsTrainingUnlocked
		{
			[Address(RVA = "0x26F4940", Offset = "0x26F3D40", Length = "0x58")]
			[Token(Token = "0x6000340")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000E6")]
		public bool IsWokeUpUnlocked
		{
			[Address(RVA = "0x26F49A0", Offset = "0x26F3DA0", Length = "0x58")]
			[Token(Token = "0x6000337")]
			 get { } //Length: 88
		}

		[Token(Token = "0x170000D3")]
		public UnlockedDateTime Item
		{
			[Address(RVA = "0x26F4A00", Offset = "0x26F3E00", Length = "0x51")]
			[Token(Token = "0x6000324")]
			 get { } //Length: 81
		}

		[Token(Token = "0x170000DC")]
		private UnlockedDateTime MoreAwakeUnlocked
		{
			[Address(RVA = "0x26F4A60", Offset = "0x26F3E60", Length = "0x49")]
			[Token(Token = "0x600032D")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000DE")]
		private UnlockedDateTime PipiruComicUnlocked
		{
			[Address(RVA = "0x26F4AB0", Offset = "0x26F3EB0", Length = "0x49")]
			[Token(Token = "0x600032F")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000DD")]
		private UnlockedDateTime PipiruPlanetUnlocked
		{
			[Address(RVA = "0x26F4B00", Offset = "0x26F3F00", Length = "0x49")]
			[Token(Token = "0x600032E")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000D2")]
		public List<UnlockedDateTime> Records
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000323")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000E1")]
		private UnlockedDateTime TrainingUnlocked
		{
			[Address(RVA = "0x26F4B50", Offset = "0x26F3F50", Length = "0x49")]
			[Token(Token = "0x6000332")]
			private get { } //Length: 73
		}

		[Token(Token = "0x170000F1")]
		public virtual int Version_now
		{
			[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
			[Token(Token = "0x600034C")]
			 get { } //Length: 6
		}

		[Token(Token = "0x170000D8")]
		private UnlockedDateTime WokeUpUnlocked
		{
			[Address(RVA = "0x26F4BA0", Offset = "0x26F3FA0", Length = "0x49")]
			[Token(Token = "0x6000329")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x26F3650", Offset = "0x26F2A50", Length = "0x71")]
		[IteratorStateMachine(typeof(<_allEnumerator>d__4))]
		[Token(Token = "0x600031F")]
		private IEnumerable<UnlockedDateTime> _allEnumerator() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000322")]
		protected virtual void _postMigrate() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000321")]
		protected virtual void _preMigrate() { }

		[Address(RVA = "0x26F36D0", Offset = "0x26F2AD0", Length = "0xAE7")]
		[Token(Token = "0x600031D")]
		public General() { }

		[Address(RVA = "0x26F2200", Offset = "0x26F1600", Length = "0x71")]
		[IteratorStateMachine(typeof(<AllEnumerator>d__5))]
		[Token(Token = "0x6000320")]
		protected virtual IEnumerable<RecordValueBase> AllEnumerator() { }

		[Address(RVA = "0x26F2280", Offset = "0x26F1680", Length = "0x58")]
		[Token(Token = "0x6000348")]
		public void ArcadeDoLock() { }

		[Address(RVA = "0x26F22E0", Offset = "0x26F16E0", Length = "0x58")]
		[Token(Token = "0x6000343")]
		public void ArcadeDoUnlock() { }

		[Address(RVA = "0x26F2340", Offset = "0x26F1740", Length = "0x58")]
		[Token(Token = "0x6000349")]
		public void ArenaDoLock() { }

		[Address(RVA = "0x26F23A0", Offset = "0x26F17A0", Length = "0x58")]
		[Token(Token = "0x6000344")]
		public void ArenaDoUnlock() { }

		[Address(RVA = "0x26F2400", Offset = "0x26F1800", Length = "0x1004")]
		[Token(Token = "0x600031E")]
		public List<String> EvaluateRecords(PlayMode playMode, DateTime unlockedDateTime) { }

		[Address(RVA = "0x26F41C0", Offset = "0x26F35C0", Length = "0x49")]
		[Token(Token = "0x6000330")]
		private UnlockedDateTime get_ArcadeUnlocked() { }

		[Address(RVA = "0x26F4210", Offset = "0x26F3610", Length = "0x49")]
		[Token(Token = "0x6000331")]
		private UnlockedDateTime get_ArenaUnlocked() { }

		[Address(RVA = "0x26F4260", Offset = "0x26F3660", Length = "0x2C")]
		[Token(Token = "0x600034B")]
		protected virtual string get_BaseName() { }

		[Address(RVA = "0x26F4290", Offset = "0x26F3690", Length = "0x49")]
		[Token(Token = "0x600032A")]
		private UnlockedDateTime get_BlackThunderLaserUnlocked() { }

		[Address(RVA = "0x26F42E0", Offset = "0x26F36E0", Length = "0x49")]
		[Token(Token = "0x6000326")]
		private UnlockedDateTime get_GameSettingsAutoBombUnlocked() { }

		[Address(RVA = "0x26F4330", Offset = "0x26F3730", Length = "0x49")]
		[Token(Token = "0x6000328")]
		private UnlockedDateTime get_GameSettingsBombsUnlocked() { }

		[Address(RVA = "0x26F4380", Offset = "0x26F3780", Length = "0x49")]
		[Token(Token = "0x600032B")]
		private UnlockedDateTime get_GameSettingsPlayers100Unlocked() { }

		[Address(RVA = "0x26F43D0", Offset = "0x26F37D0", Length = "0x46")]
		[Token(Token = "0x6000325")]
		private UnlockedDateTime get_GameSettingsPlayers10Unlocked() { }

		[Address(RVA = "0x26F4420", Offset = "0x26F3820", Length = "0x49")]
		[Token(Token = "0x600032C")]
		private UnlockedDateTime get_GameSettingsPowerUnlocked() { }

		[Address(RVA = "0x26F4470", Offset = "0x26F3870", Length = "0x49")]
		[Token(Token = "0x6000327")]
		private UnlockedDateTime get_GoldThunderLaserUnlocked() { }

		[Address(RVA = "0x26F44C0", Offset = "0x26F38C0", Length = "0x58")]
		[Token(Token = "0x600033E")]
		public bool get_IsArcadeUnlocked() { }

		[Address(RVA = "0x26F4520", Offset = "0x26F3920", Length = "0x58")]
		[Token(Token = "0x600033F")]
		public bool get_IsArenaUnlocked() { }

		[Address(RVA = "0x26F4580", Offset = "0x26F3980", Length = "0x58")]
		[Token(Token = "0x6000338")]
		public bool get_IsBlackThunderLaserUnlocked() { }

		[Address(RVA = "0x26F45E0", Offset = "0x26F39E0", Length = "0x58")]
		[Token(Token = "0x6000334")]
		public bool get_IsGameSettingsAutoBombUnlocked() { }

		[Address(RVA = "0x26F4640", Offset = "0x26F3A40", Length = "0x58")]
		[Token(Token = "0x6000336")]
		public bool get_IsGameSettingsBombsUnlocked() { }

		[Address(RVA = "0x26F46A0", Offset = "0x26F3AA0", Length = "0x58")]
		[Token(Token = "0x6000339")]
		public bool get_IsGameSettingsPlayers100Unlocked() { }

		[Address(RVA = "0x26F4700", Offset = "0x26F3B00", Length = "0x55")]
		[Token(Token = "0x6000333")]
		public bool get_IsGameSettingsPlayers10Unlocked() { }

		[Address(RVA = "0x26F4760", Offset = "0x26F3B60", Length = "0x58")]
		[Token(Token = "0x600033A")]
		public bool get_IsGameSettingsPowerUnlocked() { }

		[Address(RVA = "0x26F47C0", Offset = "0x26F3BC0", Length = "0x58")]
		[Token(Token = "0x6000335")]
		public bool get_IsGoldThunderLaserUnlocked() { }

		[Address(RVA = "0x26F4820", Offset = "0x26F3C20", Length = "0x58")]
		[Token(Token = "0x600033B")]
		public bool get_IsMoreAwakeUnlocked() { }

		[Address(RVA = "0x26F4880", Offset = "0x26F3C80", Length = "0x58")]
		[Token(Token = "0x600033D")]
		public bool get_IsPipiruComicUnlocked() { }

		[Address(RVA = "0x26F48E0", Offset = "0x26F3CE0", Length = "0x58")]
		[Token(Token = "0x600033C")]
		public bool get_IsPipiruPlanetUnlocked() { }

		[Address(RVA = "0x26F4940", Offset = "0x26F3D40", Length = "0x58")]
		[Token(Token = "0x6000340")]
		public bool get_IsTrainingUnlocked() { }

		[Address(RVA = "0x26F49A0", Offset = "0x26F3DA0", Length = "0x58")]
		[Token(Token = "0x6000337")]
		public bool get_IsWokeUpUnlocked() { }

		[Address(RVA = "0x26F4A00", Offset = "0x26F3E00", Length = "0x51")]
		[Token(Token = "0x6000324")]
		public UnlockedDateTime get_Item(Label idx) { }

		[Address(RVA = "0x26F4A60", Offset = "0x26F3E60", Length = "0x49")]
		[Token(Token = "0x600032D")]
		private UnlockedDateTime get_MoreAwakeUnlocked() { }

		[Address(RVA = "0x26F4AB0", Offset = "0x26F3EB0", Length = "0x49")]
		[Token(Token = "0x600032F")]
		private UnlockedDateTime get_PipiruComicUnlocked() { }

		[Address(RVA = "0x26F4B00", Offset = "0x26F3F00", Length = "0x49")]
		[Token(Token = "0x600032E")]
		private UnlockedDateTime get_PipiruPlanetUnlocked() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000323")]
		public List<UnlockedDateTime> get_Records() { }

		[Address(RVA = "0x26F4B50", Offset = "0x26F3F50", Length = "0x49")]
		[Token(Token = "0x6000332")]
		private UnlockedDateTime get_TrainingUnlocked() { }

		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x600034C")]
		public virtual int get_Version_now() { }

		[Address(RVA = "0x26F4BA0", Offset = "0x26F3FA0", Length = "0x49")]
		[Token(Token = "0x6000329")]
		private UnlockedDateTime get_WokeUpUnlocked() { }

		[Address(RVA = "0x26F3410", Offset = "0x26F2810", Length = "0x58")]
		[Token(Token = "0x6000347")]
		public void PipiruComicDoLock() { }

		[Address(RVA = "0x26F3470", Offset = "0x26F2870", Length = "0x58")]
		[Token(Token = "0x6000342")]
		public void PipiruComicDoUnlock() { }

		[Address(RVA = "0x26F34D0", Offset = "0x26F28D0", Length = "0x58")]
		[Token(Token = "0x6000346")]
		public void PipiruPlanetDoLock() { }

		[Address(RVA = "0x26F3530", Offset = "0x26F2930", Length = "0x58")]
		[Token(Token = "0x6000341")]
		public void PipiruPlanetDoUnlock() { }

		[Address(RVA = "0x26F3590", Offset = "0x26F2990", Length = "0x58")]
		[Token(Token = "0x600034A")]
		public void TrainingDoLock() { }

		[Address(RVA = "0x26F35F0", Offset = "0x26F29F0", Length = "0x58")]
		[Token(Token = "0x6000345")]
		public void TrainingDoUnlock() { }

	}

	[Token(Token = "0x2000067")]
	internal class Stages : RecordsBase
	{
		[CompilerGenerated]
		[Token(Token = "0x2000079")]
		private sealed class <_allEnumerator>d__12 : IEnumerable<DataBase>, IEnumerable, IEnumerator<DataBase>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002CE")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002CF")]
			private DataBase <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40002D0")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40002D1")]
			public Stages <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x40002D2")]
			private Enumerator<PlayActor, Dictionary<PlayStage, Data>> <>7__wrap1; //Field offset: 0x30
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x40002D3")]
			private Enumerator<PlayStage, Data> <>7__wrap2; //Field offset: 0x48
			[FieldOffset(Offset = "0x60")]
			[Token(Token = "0x40002D4")]
			private Enumerator<PlayMode, Data> <>7__wrap3; //Field offset: 0x60

			[Token(Token = "0x17000149")]
			private override DataBase System.Collections.Generic.IEnumerator<TXEKernel.PlayedRecords.Stages.DataBase>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000412")]
				private get { } //Length: 5
			}

			[Token(Token = "0x1700014A")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000414")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x600040C")]
			public <_allEnumerator>d__12(int <>1__state) { }

			[Address(RVA = "0x27067F0", Offset = "0x2705BF0", Length = "0x41")]
			[Token(Token = "0x600040F")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2706840", Offset = "0x2705C40", Length = "0x41")]
			[Token(Token = "0x6000410")]
			private void <>m__Finally2() { }

			[Address(RVA = "0x2706890", Offset = "0x2705C90", Length = "0x41")]
			[Token(Token = "0x6000411")]
			private void <>m__Finally3() { }

			[Address(RVA = "0x2705E80", Offset = "0x2705280", Length = "0x4F5")]
			[Token(Token = "0x600040E")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2706380", Offset = "0x2705780", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000415")]
			private override IEnumerator<DataBase> System.Collections.Generic.IEnumerable<TXEKernel.PlayedRecords.Stages.DataBase>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000412")]
			private override DataBase System.Collections.Generic.IEnumerator<TXEKernel.PlayedRecords.Stages.DataBase>.get_Current() { }

			[Address(RVA = "0x2706380", Offset = "0x2705780", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000416")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000414")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x27064C0", Offset = "0x27058C0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000413")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x27065D0", Offset = "0x27059D0", Length = "0x1B0")]
			[DebuggerHidden]
			[Token(Token = "0x600040D")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000078")]
		private sealed class <AllEnumerator>d__13 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002C8")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002C9")]
			private RecordValueBase <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40002CA")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40002CB")]
			public Stages <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x40002CC")]
			private IEnumerator<DataBase> <>7__wrap1; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x40002CD")]
			private IEnumerator<RecordValueBase> <>7__wrap2; //Field offset: 0x38

			[Token(Token = "0x17000147")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000407")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000148")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000409")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000402")]
			public <AllEnumerator>d__13(int <>1__state) { }

			[Address(RVA = "0x2701D40", Offset = "0x2701140", Length = "0x50")]
			[Token(Token = "0x6000405")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2701DE0", Offset = "0x27011E0", Length = "0x50")]
			[Token(Token = "0x6000406")]
			private void <>m__Finally2() { }

			[Address(RVA = "0x27015B0", Offset = "0x27009B0", Length = "0x3E6")]
			[Token(Token = "0x6000404")]
			private override bool MoveNext() { }

			[Address(RVA = "0x27019A0", Offset = "0x2700DA0", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600040A")]
			private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000407")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

			[Address(RVA = "0x27019A0", Offset = "0x2700DA0", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600040B")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000409")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2701B20", Offset = "0x2700F20", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000408")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2701BF0", Offset = "0x2700FF0", Length = "0x14A")]
			[DebuggerHidden]
			[Token(Token = "0x6000403")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x2000071")]
		internal class ArenaData : DataBase
		{
			[CompilerGenerated]
			[Token(Token = "0x2000076")]
			private sealed class <>c
			{
				[Token(Token = "0x40002C0")]
				public static readonly <>c <>9; //Field offset: 0x0
				[Token(Token = "0x40002C1")]
				public static Comparison<WorkTemp> <>9__5_0; //Field offset: 0x8

				[Address(RVA = "0x2705880", Offset = "0x2704C80", Length = "0x67")]
				[Token(Token = "0x60003F4")]
				private static <>c() { }

				[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
				[Token(Token = "0x60003F5")]
				public <>c() { }

				[Address(RVA = "0x2705840", Offset = "0x2704C40", Length = "0x34")]
				[Token(Token = "0x60003F6")]
				internal int <Update>b__5_0(WorkTemp a, WorkTemp b) { }

			}

			[CompilerGenerated]
			[Token(Token = "0x2000077")]
			private sealed class <AllEnumerator>d__2 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x40002C2")]
				private int <>1__state; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x40002C3")]
				private RecordValueBase <>2__current; //Field offset: 0x18
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x40002C4")]
				private int <>l__initialThreadId; //Field offset: 0x20
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x40002C5")]
				public ArenaData <>4__this; //Field offset: 0x28
				[FieldOffset(Offset = "0x30")]
				[Token(Token = "0x40002C6")]
				private IEnumerator<RecordValueBase> <>7__wrap1; //Field offset: 0x30
				[FieldOffset(Offset = "0x38")]
				[Token(Token = "0x40002C7")]
				private Enumerator<ArenaRanking> <>7__wrap2; //Field offset: 0x38

				[Token(Token = "0x17000145")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003FD")]
					private get { } //Length: 5
				}

				[Token(Token = "0x17000146")]
				private override object System.Collections.IEnumerator.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003FF")]
					private get { } //Length: 5
				}

				[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
				[DebuggerHidden]
				[Token(Token = "0x60003F7")]
				public <AllEnumerator>d__2(int <>1__state) { }

				[Address(RVA = "0x2703720", Offset = "0x2702B20", Length = "0x50")]
				[Token(Token = "0x60003FA")]
				private void <>m__Finally1() { }

				[Address(RVA = "0x2703770", Offset = "0x2702B70", Length = "0x41")]
				[Token(Token = "0x60003FB")]
				private void <>m__Finally2() { }

				[Address(RVA = "0x27037C0", Offset = "0x2702BC0", Length = "0x50")]
				[Token(Token = "0x60003FC")]
				private void <>m__Finally3() { }

				[Address(RVA = "0x2702600", Offset = "0x2701A00", Length = "0x5D8")]
				[Token(Token = "0x60003F9")]
				private override bool MoveNext() { }

				[Address(RVA = "0x2703260", Offset = "0x2702660", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x6000400")]
				private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60003FD")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

				[Address(RVA = "0x2703260", Offset = "0x2702660", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x6000401")]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60003FF")]
				private override object System.Collections.IEnumerator.get_Current() { }

				[Address(RVA = "0x2703400", Offset = "0x2702800", Length = "0x3E")]
				[DebuggerHidden]
				[Token(Token = "0x60003FE")]
				private override void System.Collections.IEnumerator.Reset() { }

				[Address(RVA = "0x27034D0", Offset = "0x27028D0", Length = "0x1E0")]
				[DebuggerHidden]
				[Token(Token = "0x60003F8")]
				private override void System.IDisposable.Dispose() { }

			}

			[Token(Token = "0x2000072")]
			internal class ArenaDataParams : DataBaseParams
			{
				[CompilerGenerated]
				[FieldOffset(Offset = "0x40")]
				[Token(Token = "0x40002B2")]
				private readonly string <KeyPlayCount>k__BackingField; //Field offset: 0x40
				[CompilerGenerated]
				[FieldOffset(Offset = "0x48")]
				[Token(Token = "0x40002B3")]
				private readonly string <KeyNumberOfRanks>k__BackingField; //Field offset: 0x48
				[CompilerGenerated]
				[FieldOffset(Offset = "0x50")]
				[Token(Token = "0x40002B4")]
				private readonly string <KeyLocalRankings>k__BackingField; //Field offset: 0x50
				[CompilerGenerated]
				[FieldOffset(Offset = "0x58")]
				[Token(Token = "0x40002B5")]
				private readonly string <KeyStartStage>k__BackingField; //Field offset: 0x58
				[CompilerGenerated]
				[FieldOffset(Offset = "0x60")]
				[Token(Token = "0x40002B6")]
				private readonly string <KeyLives>k__BackingField; //Field offset: 0x60
				[CompilerGenerated]
				[FieldOffset(Offset = "0x68")]
				[Token(Token = "0x40002B7")]
				private readonly string <KeyStartBombs>k__BackingField; //Field offset: 0x68

				[Token(Token = "0x1700013F")]
				public string KeyLives
				{
					[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003E3")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700013D")]
				public string KeyLocalRankings
				{
					[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003E1")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700013C")]
				public string KeyNumberOfRanks
				{
					[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003E0")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700013B")]
				public string KeyPlayCount
				{
					[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003DF")]
					 get { } //Length: 5
				}

				[Token(Token = "0x17000140")]
				public string KeyStartBombs
				{
					[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003E4")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700013E")]
				public string KeyStartStage
				{
					[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003E2")]
					 get { } //Length: 5
				}

				[Address(RVA = "0x26EC610", Offset = "0x26EBA10", Length = "0x14C")]
				[Token(Token = "0x60003DE")]
				public ArenaDataParams(string baseName) { }

				[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003E3")]
				public string get_KeyLives() { }

				[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003E1")]
				public string get_KeyLocalRankings() { }

				[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003E0")]
				public string get_KeyNumberOfRanks() { }

				[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003DF")]
				public string get_KeyPlayCount() { }

				[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003E4")]
				public string get_KeyStartBombs() { }

				[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003E2")]
				public string get_KeyStartStage() { }

			}

			[Token(Token = "0x2000074")]
			internal class ArenaRanking
			{
				[CompilerGenerated]
				[Token(Token = "0x2000075")]
				private sealed class <AllEnumerator>d__2 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
				{
					[FieldOffset(Offset = "0x10")]
					[Token(Token = "0x40002BC")]
					private int <>1__state; //Field offset: 0x10
					[FieldOffset(Offset = "0x18")]
					[Token(Token = "0x40002BD")]
					private RecordValueBase <>2__current; //Field offset: 0x18
					[FieldOffset(Offset = "0x20")]
					[Token(Token = "0x40002BE")]
					private int <>l__initialThreadId; //Field offset: 0x20
					[FieldOffset(Offset = "0x28")]
					[Token(Token = "0x40002BF")]
					public ArenaRanking <>4__this; //Field offset: 0x28

					[Token(Token = "0x17000143")]
					private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
					{
						[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
						[DebuggerHidden]
						[Token(Token = "0x60003EF")]
						private get { } //Length: 5
					}

					[Token(Token = "0x17000144")]
					private override object System.Collections.IEnumerator.Current
					{
						[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
						[DebuggerHidden]
						[Token(Token = "0x60003F1")]
						private get { } //Length: 5
					}

					[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
					[DebuggerHidden]
					[Token(Token = "0x60003EC")]
					public <AllEnumerator>d__2(int <>1__state) { }

					[Address(RVA = "0x2702F50", Offset = "0x2702350", Length = "0x8A")]
					[Token(Token = "0x60003EE")]
					private override bool MoveNext() { }

					[Address(RVA = "0x2703120", Offset = "0x2702520", Length = "0x9C")]
					[DebuggerHidden]
					[Token(Token = "0x60003F2")]
					private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003EF")]
					private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

					[Address(RVA = "0x2703120", Offset = "0x2702520", Length = "0x9C")]
					[DebuggerHidden]
					[Token(Token = "0x60003F3")]
					private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003F1")]
					private override object System.Collections.IEnumerator.get_Current() { }

					[Address(RVA = "0x27033C0", Offset = "0x27027C0", Length = "0x3E")]
					[DebuggerHidden]
					[Token(Token = "0x60003F0")]
					private override void System.Collections.IEnumerator.Reset() { }

					[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
					[DebuggerHidden]
					[Token(Token = "0x60003ED")]
					private override void System.IDisposable.Dispose() { }

				}

				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x40002BA")]
				private RecordClampedInt64 _score; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x40002BB")]
				private RecordClampedInt64 _playerNo; //Field offset: 0x18

				[Token(Token = "0x17000142")]
				public int PlayerNo
				{
					[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
					[Token(Token = "0x60003EB")]
					 get { } //Length: 42
				}

				[Token(Token = "0x17000141")]
				public long Score
				{
					[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
					[Token(Token = "0x60003EA")]
					 get { } //Length: 42
				}

				[Address(RVA = "0x26ED6D0", Offset = "0x26ECAD0", Length = "0x1AA")]
				[Token(Token = "0x60003E7")]
				public ArenaRanking(string baseName) { }

				[Address(RVA = "0x26ED650", Offset = "0x26ECA50", Length = "0x71")]
				[IteratorStateMachine(typeof(<AllEnumerator>d__2))]
				[Token(Token = "0x60003E9")]
				public IEnumerable<RecordValueBase> AllEnumerator() { }

				[Address(RVA = "0x26ED880", Offset = "0x26ECC80", Length = "0x65")]
				[Token(Token = "0x60003E8")]
				public void changeData(WorkTemp setData) { }

				[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
				[Token(Token = "0x60003EB")]
				public int get_PlayerNo() { }

				[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
				[Token(Token = "0x60003EA")]
				public long get_Score() { }

			}

			[Token(Token = "0x2000073")]
			internal class WorkTemp
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x40002B8")]
				public long Score; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x40002B9")]
				public int PlayerNo; //Field offset: 0x18

				[Address(RVA = "0x2708350", Offset = "0x2707750", Length = "0x36")]
				[Token(Token = "0x60003E5")]
				public WorkTemp(long score, int playerNo) { }

				[Address(RVA = "0x2708390", Offset = "0x2707790", Length = "0x383")]
				[Token(Token = "0x60003E6")]
				public WorkTemp(ArenaRanking org) { }

			}

			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x40002AC")]
			private RecordClampedInt64 _playCount; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x40002AD")]
			private RecordClampedInt64 _numberOfRanks; //Field offset: 0x48
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x40002AE")]
			private RecordClampedInt64 _startStage; //Field offset: 0x50
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x40002AF")]
			private RecordClampedInt64 _lives; //Field offset: 0x58
			[FieldOffset(Offset = "0x60")]
			[Token(Token = "0x40002B0")]
			private RecordClampedInt64 _startBombs; //Field offset: 0x60
			[FieldOffset(Offset = "0x68")]
			[Token(Token = "0x40002B1")]
			private List<ArenaRanking> _localRankings; //Field offset: 0x68

			[Token(Token = "0x17000138")]
			public bool Lives
			{
				[Address(RVA = "0x26ED500", Offset = "0x26EC900", Length = "0x30")]
				[Token(Token = "0x60003D8")]
				 get { } //Length: 48
				[Address(RVA = "0x26ED5C0", Offset = "0x26EC9C0", Length = "0x2D")]
				[Token(Token = "0x60003D9")]
				 set { } //Length: 45
			}

			[Token(Token = "0x1700013A")]
			public List<ArenaRanking> LocalRankings
			{
				[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
				[Token(Token = "0x60003DC")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000136")]
			public int NumberOfRanks
			{
				[Address(RVA = "0x22298E0", Offset = "0x2228CE0", Length = "0x2A")]
				[Token(Token = "0x60003D5")]
				 get { } //Length: 42
			}

			[Token(Token = "0x17000135")]
			public int PlayCount
			{
				[Address(RVA = "0x26D50E0", Offset = "0x26D44E0", Length = "0x2A")]
				[Token(Token = "0x60003D4")]
				 get { } //Length: 42
			}

			[Token(Token = "0x17000139")]
			public int StartBombs
			{
				[Address(RVA = "0x26ED540", Offset = "0x26EC940", Length = "0x2A")]
				[Token(Token = "0x60003DA")]
				 get { } //Length: 42
				[Address(RVA = "0x26ED5F0", Offset = "0x26EC9F0", Length = "0x2D")]
				[Token(Token = "0x60003DB")]
				 set { } //Length: 45
			}

			[Token(Token = "0x17000137")]
			public int StartStage
			{
				[Address(RVA = "0x26D4EA0", Offset = "0x26D42A0", Length = "0x2A")]
				[Token(Token = "0x60003D6")]
				 get { } //Length: 42
				[Address(RVA = "0x26ED620", Offset = "0x26ECA20", Length = "0x2D")]
				[Token(Token = "0x60003D7")]
				 set { } //Length: 45
			}

			[Address(RVA = "0x26ECD50", Offset = "0x26EC150", Length = "0x627")]
			[Token(Token = "0x60003CE")]
			public ArenaData(ArenaDataParams dataParams) { }

			[Address(RVA = "0x26EC840", Offset = "0x26EBC40", Length = "0x7")]
			[CompilerGenerated]
			[DebuggerHidden]
			[Token(Token = "0x60003DD")]
			private IEnumerable<RecordValueBase> <>n__0() { }

			[Address(RVA = "0x26EC760", Offset = "0x26EBB60", Length = "0x71")]
			[IteratorStateMachine(typeof(<AllEnumerator>d__2))]
			[Token(Token = "0x60003CF")]
			public virtual IEnumerable<RecordValueBase> AllEnumerator() { }

			[Address(RVA = "0x26EC7E0", Offset = "0x26EBBE0", Length = "0x50")]
			[Token(Token = "0x60003D0")]
			public void ClearRankings() { }

			[Address(RVA = "0x26ED500", Offset = "0x26EC900", Length = "0x30")]
			[Token(Token = "0x60003D8")]
			public bool get_Lives() { }

			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[Token(Token = "0x60003DC")]
			public List<ArenaRanking> get_LocalRankings() { }

			[Address(RVA = "0x22298E0", Offset = "0x2228CE0", Length = "0x2A")]
			[Token(Token = "0x60003D5")]
			public int get_NumberOfRanks() { }

			[Address(RVA = "0x26D50E0", Offset = "0x26D44E0", Length = "0x2A")]
			[Token(Token = "0x60003D4")]
			public int get_PlayCount() { }

			[Address(RVA = "0x26ED540", Offset = "0x26EC940", Length = "0x2A")]
			[Token(Token = "0x60003DA")]
			public int get_StartBombs() { }

			[Address(RVA = "0x26D4EA0", Offset = "0x26D42A0", Length = "0x2A")]
			[Token(Token = "0x60003D6")]
			public int get_StartStage() { }

			[Address(RVA = "0x26ED380", Offset = "0x26EC780", Length = "0x174")]
			[Token(Token = "0x60003D3")]
			public int getRankIndex(int playerNo) { }

			[Address(RVA = "0x26ED570", Offset = "0x26EC970", Length = "0x4A")]
			[Token(Token = "0x60003D1")]
			public void incPlayCount() { }

			[Address(RVA = "0x26ED5C0", Offset = "0x26EC9C0", Length = "0x2D")]
			[Token(Token = "0x60003D9")]
			public void set_Lives(bool value) { }

			[Address(RVA = "0x26ED5F0", Offset = "0x26EC9F0", Length = "0x2D")]
			[Token(Token = "0x60003DB")]
			public void set_StartBombs(int value) { }

			[Address(RVA = "0x26ED620", Offset = "0x26ECA20", Length = "0x2D")]
			[Token(Token = "0x60003D7")]
			public void set_StartStage(int value) { }

			[Address(RVA = "0x26EC850", Offset = "0x26EBC50", Length = "0x4F8")]
			[Token(Token = "0x60003D2")]
			public void Update(in UpdateParams param, in DateTime updateDateTime, bool validTestFlg) { }

		}

		[Token(Token = "0x200006C")]
		internal class Data : DataBase
		{
			[CompilerGenerated]
			[Token(Token = "0x200006E")]
			private sealed class <AllEnumerator>d__2 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x40002A7")]
				private int <>1__state; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x40002A8")]
				private RecordValueBase <>2__current; //Field offset: 0x18
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x40002A9")]
				private int <>l__initialThreadId; //Field offset: 0x20
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x40002AA")]
				public Data <>4__this; //Field offset: 0x28
				[FieldOffset(Offset = "0x30")]
				[Token(Token = "0x40002AB")]
				private IEnumerator<RecordValueBase> <>7__wrap1; //Field offset: 0x30

				[Token(Token = "0x17000133")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003C6")]
					private get { } //Length: 5
				}

				[Token(Token = "0x17000134")]
				private override object System.Collections.IEnumerator.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003C8")]
					private get { } //Length: 5
				}

				[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
				[DebuggerHidden]
				[Token(Token = "0x60003C2")]
				public <AllEnumerator>d__2(int <>1__state) { }

				[Address(RVA = "0x27036D0", Offset = "0x2702AD0", Length = "0x50")]
				[Token(Token = "0x60003C5")]
				private void <>m__Finally1() { }

				[Address(RVA = "0x2702C00", Offset = "0x2702000", Length = "0x32C")]
				[Token(Token = "0x60003C4")]
				private override bool MoveNext() { }

				[Address(RVA = "0x27031C0", Offset = "0x27025C0", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x60003C9")]
				private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60003C6")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

				[Address(RVA = "0x27031C0", Offset = "0x27025C0", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x60003CA")]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60003C8")]
				private override object System.Collections.IEnumerator.get_Current() { }

				[Address(RVA = "0x2703300", Offset = "0x2702700", Length = "0x3E")]
				[DebuggerHidden]
				[Token(Token = "0x60003C7")]
				private override void System.Collections.IEnumerator.Reset() { }

				[Address(RVA = "0x2703440", Offset = "0x2702840", Length = "0x8C")]
				[DebuggerHidden]
				[Token(Token = "0x60003C3")]
				private override void System.IDisposable.Dispose() { }

			}

			[Token(Token = "0x200006D")]
			internal class DataParams : DataBaseParams
			{
				[CompilerGenerated]
				[FieldOffset(Offset = "0x40")]
				[Token(Token = "0x40002A2")]
				private readonly string <KeyHiScoreUnOfficial>k__BackingField; //Field offset: 0x40
				[CompilerGenerated]
				[FieldOffset(Offset = "0x48")]
				[Token(Token = "0x40002A3")]
				private readonly string <KeyHiScoreUnOfficialDateTime>k__BackingField; //Field offset: 0x48
				[CompilerGenerated]
				[FieldOffset(Offset = "0x50")]
				[Token(Token = "0x40002A4")]
				private readonly string <KeyHighestRound>k__BackingField; //Field offset: 0x50
				[CompilerGenerated]
				[FieldOffset(Offset = "0x58")]
				[Token(Token = "0x40002A5")]
				private readonly string <KeyHighestStage>k__BackingField; //Field offset: 0x58
				[CompilerGenerated]
				[FieldOffset(Offset = "0x60")]
				[Token(Token = "0x40002A6")]
				private readonly string <KeyClearCount>k__BackingField; //Field offset: 0x60

				[Token(Token = "0x17000132")]
				public string KeyClearCount
				{
					[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003C1")]
					 get { } //Length: 5
				}

				[Token(Token = "0x17000130")]
				public string KeyHighestRound
				{
					[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003BF")]
					 get { } //Length: 5
				}

				[Token(Token = "0x17000131")]
				public string KeyHighestStage
				{
					[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003C0")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700012E")]
				public string KeyHiScoreUnOfficial
				{
					[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003BD")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700012F")]
				public string KeyHiScoreUnOfficialDateTime
				{
					[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003BE")]
					 get { } //Length: 5
				}

				[Address(RVA = "0x26EF890", Offset = "0x26EEC90", Length = "0x11E")]
				[Token(Token = "0x60003BC")]
				public DataParams(string baseName) { }

				[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003C1")]
				public string get_KeyClearCount() { }

				[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003BF")]
				public string get_KeyHighestRound() { }

				[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003C0")]
				public string get_KeyHighestStage() { }

				[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003BD")]
				public string get_KeyHiScoreUnOfficial() { }

				[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003BE")]
				public string get_KeyHiScoreUnOfficialDateTime() { }

			}

			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x400029D")]
			private RecordClampedInt64 _hiScoreUnOfficial; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x400029E")]
			private RecordDateTime _hiScoreUnOfficialDateTime; //Field offset: 0x48
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x400029F")]
			private RecordClampedInt64 _highestRound; //Field offset: 0x50
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x40002A0")]
			private RecordClampedInt64 _highestStage; //Field offset: 0x58
			[FieldOffset(Offset = "0x60")]
			[Token(Token = "0x40002A1")]
			private RecordClampedInt64 _clearCount; //Field offset: 0x60

			[Token(Token = "0x1700012D")]
			public long ClearCount
			{
				[Address(RVA = "0x26ED540", Offset = "0x26EC940", Length = "0x2A")]
				[Token(Token = "0x60003BA")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700012B")]
			public int HighestRound
			{
				[Address(RVA = "0x26D4EA0", Offset = "0x26D42A0", Length = "0x2A")]
				[Token(Token = "0x60003B8")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700012C")]
			public int HighestStage
			{
				[Address(RVA = "0x26D5050", Offset = "0x26D4450", Length = "0x2A")]
				[Token(Token = "0x60003B9")]
				 get { } //Length: 42
			}

			[Token(Token = "0x17000126")]
			public virtual long HiScore
			{
				[Address(RVA = "0x26F0940", Offset = "0x26EFD40", Length = "0x81")]
				[Token(Token = "0x60003B1")]
				 get { } //Length: 129
			}

			[Token(Token = "0x17000127")]
			public long HiScoreOfficial
			{
				[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
				[Token(Token = "0x60003B2")]
				 get { } //Length: 42
			}

			[Token(Token = "0x17000129")]
			public DateTime HiScoreOfficialDateTime
			{
				[Address(RVA = "0x26EF810", Offset = "0x26EEC10", Length = "0x1D")]
				[Token(Token = "0x60003B4")]
				 get { } //Length: 29
			}

			[Token(Token = "0x17000128")]
			public long HiScoreUnOfficial
			{
				[Address(RVA = "0x26D50E0", Offset = "0x26D44E0", Length = "0x2A")]
				[Token(Token = "0x60003B3")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700012A")]
			public DateTime HiScoreUnOfficialDateTime
			{
				[Address(RVA = "0x26F0920", Offset = "0x26EFD20", Length = "0x1D")]
				[Token(Token = "0x60003B6")]
				 get { } //Length: 29
			}

			[Address(RVA = "0x26F05B0", Offset = "0x26EF9B0", Length = "0x312")]
			[Token(Token = "0x60003AD")]
			public Data(DataParams dataParams) { }

			[Address(RVA = "0x26EC840", Offset = "0x26EBC40", Length = "0x7")]
			[CompilerGenerated]
			[DebuggerHidden]
			[Token(Token = "0x60003BB")]
			private IEnumerable<RecordValueBase> <>n__0() { }

			[Address(RVA = "0x26EFAF0", Offset = "0x26EEEF0", Length = "0x71")]
			[IteratorStateMachine(typeof(<AllEnumerator>d__2))]
			[Token(Token = "0x60003AE")]
			public virtual IEnumerable<RecordValueBase> AllEnumerator() { }

			[Address(RVA = "0x26ED540", Offset = "0x26EC940", Length = "0x2A")]
			[Token(Token = "0x60003BA")]
			public long get_ClearCount() { }

			[Address(RVA = "0x26D4EA0", Offset = "0x26D42A0", Length = "0x2A")]
			[Token(Token = "0x60003B8")]
			public int get_HighestRound() { }

			[Address(RVA = "0x26D5050", Offset = "0x26D4450", Length = "0x2A")]
			[Token(Token = "0x60003B9")]
			public int get_HighestStage() { }

			[Address(RVA = "0x26F0940", Offset = "0x26EFD40", Length = "0x81")]
			[Token(Token = "0x60003B1")]
			public virtual long get_HiScore() { }

			[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
			[Token(Token = "0x60003B2")]
			public long get_HiScoreOfficial() { }

			[Address(RVA = "0x26EF810", Offset = "0x26EEC10", Length = "0x1D")]
			[Token(Token = "0x60003B4")]
			public DateTime get_HiScoreOfficialDateTime() { }

			[Address(RVA = "0x26D50E0", Offset = "0x26D44E0", Length = "0x2A")]
			[Token(Token = "0x60003B3")]
			public long get_HiScoreUnOfficial() { }

			[Address(RVA = "0x26F0920", Offset = "0x26EFD20", Length = "0x1D")]
			[Token(Token = "0x60003B6")]
			public DateTime get_HiScoreUnOfficialDateTime() { }

			[Address(RVA = "0x26EFC50", Offset = "0x26EF050", Length = "0x54")]
			[Token(Token = "0x60003B0")]
			private bool IsDefaultSetting() { }

			[Address(RVA = "0x26EDD50", Offset = "0x26ED150", Length = "0x1D")]
			[Token(Token = "0x60003B5")]
			public bool IsValidHiScoreOfficialDateTime() { }

			[Address(RVA = "0x26EFD20", Offset = "0x26EF120", Length = "0x1D")]
			[Token(Token = "0x60003B7")]
			public bool IsValidHiScoreUnOfficialDateTime() { }

			[Address(RVA = "0x26EFE20", Offset = "0x26EF220", Length = "0x3CF")]
			[Token(Token = "0x60003AF")]
			public void Update(in UpdateParams param, bool isBossDestroy, bool isGameEnd, in DateTime updateDateTime, bool validTestFlg) { }

		}

		[Token(Token = "0x2000069")]
		internal abstract class DataBase
		{
			[CompilerGenerated]
			[Token(Token = "0x200006B")]
			private sealed class <AllEnumerator>d__2 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x4000299")]
				private int <>1__state; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x400029A")]
				private RecordValueBase <>2__current; //Field offset: 0x18
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x400029B")]
				private int <>l__initialThreadId; //Field offset: 0x20
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x400029C")]
				public DataBase <>4__this; //Field offset: 0x28

				[Token(Token = "0x17000124")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003A8")]
					private get { } //Length: 5
				}

				[Token(Token = "0x17000125")]
				private override object System.Collections.IEnumerator.Current
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[DebuggerHidden]
					[Token(Token = "0x60003AA")]
					private get { } //Length: 5
				}

				[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
				[DebuggerHidden]
				[Token(Token = "0x60003A5")]
				public <AllEnumerator>d__2(int <>1__state) { }

				[Address(RVA = "0x2702110", Offset = "0x2701510", Length = "0x15C")]
				[Token(Token = "0x60003A7")]
				private override bool MoveNext() { }

				[Address(RVA = "0x2702FE0", Offset = "0x27023E0", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x60003AB")]
				private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60003A8")]
				private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

				[Address(RVA = "0x2702FE0", Offset = "0x27023E0", Length = "0x9C")]
				[DebuggerHidden]
				[Token(Token = "0x60003AC")]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60003AA")]
				private override object System.Collections.IEnumerator.get_Current() { }

				[Address(RVA = "0x2703340", Offset = "0x2702740", Length = "0x3E")]
				[DebuggerHidden]
				[Token(Token = "0x60003A9")]
				private override void System.Collections.IEnumerator.Reset() { }

				[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
				[DebuggerHidden]
				[Token(Token = "0x60003A6")]
				private override void System.IDisposable.Dispose() { }

			}

			[Token(Token = "0x200006A")]
			internal class DataBaseParams
			{
				[CompilerGenerated]
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x4000293")]
				private readonly string <KeyTotalScore>k__BackingField; //Field offset: 0x10
				[CompilerGenerated]
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x4000294")]
				private readonly string <KeyHiScore>k__BackingField; //Field offset: 0x18
				[CompilerGenerated]
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x4000295")]
				private readonly string <KeyHiScoreDateTime>k__BackingField; //Field offset: 0x20
				[CompilerGenerated]
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x4000296")]
				private readonly string <KeyPlayTime>k__BackingField; //Field offset: 0x28
				[CompilerGenerated]
				[FieldOffset(Offset = "0x30")]
				[Token(Token = "0x4000297")]
				private readonly string <KeyPipiruCount>k__BackingField; //Field offset: 0x30
				[CompilerGenerated]
				[FieldOffset(Offset = "0x38")]
				[Token(Token = "0x4000298")]
				private readonly string <KeyAmberJewelCount>k__BackingField; //Field offset: 0x38

				[Token(Token = "0x17000123")]
				public string KeyAmberJewelCount
				{
					[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003A4")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700011F")]
				public string KeyHiScore
				{
					[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003A0")]
					 get { } //Length: 5
				}

				[Token(Token = "0x17000120")]
				public string KeyHiScoreDateTime
				{
					[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003A1")]
					 get { } //Length: 5
				}

				[Token(Token = "0x17000122")]
				public string KeyPipiruCount
				{
					[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003A3")]
					 get { } //Length: 5
				}

				[Token(Token = "0x17000121")]
				public string KeyPlayTime
				{
					[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x60003A2")]
					 get { } //Length: 5
				}

				[Token(Token = "0x1700011E")]
				public string KeyTotalScore
				{
					[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
					[CompilerGenerated]
					[Token(Token = "0x600039F")]
					 get { } //Length: 5
				}

				[Address(RVA = "0x26EDB80", Offset = "0x26ECF80", Length = "0x148")]
				[Token(Token = "0x600039E")]
				public DataBaseParams(string baseName) { }

				[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003A4")]
				public string get_KeyAmberJewelCount() { }

				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003A0")]
				public string get_KeyHiScore() { }

				[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003A1")]
				public string get_KeyHiScoreDateTime() { }

				[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003A3")]
				public string get_KeyPipiruCount() { }

				[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60003A2")]
				public string get_KeyPlayTime() { }

				[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600039F")]
				public string get_KeyTotalScore() { }

			}

			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400028D")]
			private RecordClampedInt64 _totalScore; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400028E")]
			private RecordClampedInt64 _hiScore; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400028F")]
			private RecordDateTime _hiScoreDateTime; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000290")]
			private RecordTime _playTime; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000291")]
			private RecordClampedInt64 _pipiruCount; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000292")]
			private RecordClampedInt64 _amberJewelCount; //Field offset: 0x38

			[Token(Token = "0x1700011D")]
			public long AmberJewelCount
			{
				[Address(RVA = "0x1EDACC0", Offset = "0x1EDA0C0", Length = "0x2A")]
				[Token(Token = "0x600039D")]
				 get { } //Length: 42
			}

			[Token(Token = "0x17000119")]
			public override long HiScore
			{
				[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
				[Token(Token = "0x6000398")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700011A")]
			public DateTime HiScoreDateTime
			{
				[Address(RVA = "0x26EF810", Offset = "0x26EEC10", Length = "0x1D")]
				[Token(Token = "0x6000399")]
				 get { } //Length: 29
			}

			[Token(Token = "0x1700011C")]
			public long PipiruCount
			{
				[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
				[Token(Token = "0x600039C")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700011B")]
			public long PlayTime
			{
				[Address(RVA = "0x26EF830", Offset = "0x26EEC30", Length = "0x52")]
				[Token(Token = "0x600039B")]
				 get { } //Length: 82
			}

			[Token(Token = "0x17000118")]
			public long TotalScore
			{
				[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
				[Token(Token = "0x6000397")]
				 get { } //Length: 42
			}

			[Address(RVA = "0x26EDD70", Offset = "0x26ED170", Length = "0x16D8")]
			[Token(Token = "0x6000396")]
			protected void _Update(in UpdateParams param, bool scoreUpdate, bool isGameEnd, in DateTime updateDateTime, bool validTestFlg) { }

			[Address(RVA = "0x26EF450", Offset = "0x26EE850", Length = "0x3B1")]
			[Token(Token = "0x6000394")]
			public DataBase(DataBaseParams dataParams) { }

			[Address(RVA = "0x26EDCD0", Offset = "0x26ED0D0", Length = "0x71")]
			[IteratorStateMachine(typeof(<AllEnumerator>d__2))]
			[Token(Token = "0x6000395")]
			public override IEnumerable<RecordValueBase> AllEnumerator() { }

			[Address(RVA = "0x1EDACC0", Offset = "0x1EDA0C0", Length = "0x2A")]
			[Token(Token = "0x600039D")]
			public long get_AmberJewelCount() { }

			[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
			[Token(Token = "0x6000398")]
			public override long get_HiScore() { }

			[Address(RVA = "0x26EF810", Offset = "0x26EEC10", Length = "0x1D")]
			[Token(Token = "0x6000399")]
			public DateTime get_HiScoreDateTime() { }

			[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
			[Token(Token = "0x600039C")]
			public long get_PipiruCount() { }

			[Address(RVA = "0x26EF830", Offset = "0x26EEC30", Length = "0x52")]
			[Token(Token = "0x600039B")]
			public long get_PlayTime() { }

			[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
			[Token(Token = "0x6000397")]
			public long get_TotalScore() { }

			[Address(RVA = "0x26EDD50", Offset = "0x26ED150", Length = "0x1D")]
			[Token(Token = "0x600039A")]
			public bool IsValidHiScoreDateTime() { }

		}

		[Token(Token = "0x200006F")]
		internal class HeartStarterData : DataBase
		{
			[Token(Token = "0x2000070")]
			internal class HeartStarterDataParams : DataBaseParams
			{

				[Address(RVA = "0x26F4BF0", Offset = "0x26F3FF0", Length = "0x8")]
				[Token(Token = "0x60003CD")]
				public HeartStarterDataParams(string baseName) { }

			}


			[Address(RVA = "0x26F4C30", Offset = "0x26F4030", Length = "0x8")]
			[Token(Token = "0x60003CB")]
			public HeartStarterData(HeartStarterDataParams dataParams) { }

			[Address(RVA = "0x26F4C00", Offset = "0x26F4000", Length = "0x28")]
			[Token(Token = "0x60003CC")]
			public void Update(in UpdateParams param, in DateTime updateDateTime, bool validTestFlg) { }

		}

		[Token(Token = "0x2000068")]
		internal class UpdateParams
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000288")]
			private StageInformation _stageInformation; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000289")]
			private PlayerInformation _playerInformation; //Field offset: 0x18
			[CompilerGenerated]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400028A")]
			private PlayMode <playMode>k__BackingField; //Field offset: 0x20
			[CompilerGenerated]
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x400028B")]
			private int <playerDeathsBonusCount>k__BackingField; //Field offset: 0x24
			[CompilerGenerated]
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400028C")]
			private int <destructionRateBonusCount>k__BackingField; //Field offset: 0x28

			[Token(Token = "0x17000107")]
			public long amberJewelCount
			{
				[Address(RVA = "0x2707DB0", Offset = "0x27071B0", Length = "0x24")]
				[Token(Token = "0x6000381")]
				 get { } //Length: 36
			}

			[Token(Token = "0x17000111")]
			public int armBeamCount
			{
				[Address(RVA = "0x2707DE0", Offset = "0x27071E0", Length = "0x5B")]
				[Token(Token = "0x600038D")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000116")]
			public int armBlackCount
			{
				[Address(RVA = "0x2707E40", Offset = "0x2707240", Length = "0x5B")]
				[Token(Token = "0x6000392")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000115")]
			public int armGoldCount
			{
				[Address(RVA = "0x2707EA0", Offset = "0x27072A0", Length = "0x5B")]
				[Token(Token = "0x6000391")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000114")]
			public int armHormingCount
			{
				[Address(RVA = "0x2707F00", Offset = "0x2707300", Length = "0x5B")]
				[Token(Token = "0x6000390")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000112")]
			public int armLaserCount
			{
				[Address(RVA = "0x2707F60", Offset = "0x2707360", Length = "0x5B")]
				[Token(Token = "0x600038E")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000110")]
			public int armNormalCount
			{
				[Address(RVA = "0x2707FC0", Offset = "0x27073C0", Length = "0x5B")]
				[Token(Token = "0x600038C")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000113")]
			public int armStarmineCount
			{
				[Address(RVA = "0x2708020", Offset = "0x2707420", Length = "0x5B")]
				[Token(Token = "0x600038F")]
				 get { } //Length: 91
			}

			[Token(Token = "0x1700010F")]
			public int bombStockCount
			{
				[Address(RVA = "0x2708080", Offset = "0x2707480", Length = "0x5B")]
				[Token(Token = "0x600038B")]
				 get { } //Length: 91
			}

			[Token(Token = "0x1700010A")]
			public int bossTime
			{
				[Address(RVA = "0x27080E0", Offset = "0x27074E0", Length = "0x1A")]
				[Token(Token = "0x6000386")]
				 get { } //Length: 26
			}

			[Token(Token = "0x17000109")]
			public private int destructionRateBonusCount
			{
				[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000384")]
				 get { } //Length: 4
				[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000385")]
				private set { } //Length: 4
			}

			[Token(Token = "0x17000117")]
			public bool isLoopFlag
			{
				[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
				[Token(Token = "0x6000393")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700010B")]
			public int p5000Count
			{
				[Address(RVA = "0x2708100", Offset = "0x2707500", Length = "0x58")]
				[Token(Token = "0x6000387")]
				 get { } //Length: 88
			}

			[Token(Token = "0x17000106")]
			public long pipiruCount
			{
				[Address(RVA = "0x2708160", Offset = "0x2707560", Length = "0x23")]
				[Token(Token = "0x6000380")]
				 get { } //Length: 35
			}

			[Token(Token = "0x17000101")]
			public PlayActor playActor
			{
				[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
				[Token(Token = "0x600037B")]
				 get { } //Length: 42
			}

			[Token(Token = "0x17000105")]
			public long playedMSecounds
			{
				[Address(RVA = "0x2708190", Offset = "0x2707590", Length = "0x2B")]
				[Token(Token = "0x600037F")]
				 get { } //Length: 43
			}

			[Token(Token = "0x17000108")]
			public private int playerDeathsBonusCount
			{
				[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000382")]
				 get { } //Length: 4
				[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000383")]
				private set { } //Length: 4
			}

			[Token(Token = "0x170000FF")]
			public int playerNo
			{
				[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
				[Token(Token = "0x6000378")]
				 get { } //Length: 42
			}

			[Token(Token = "0x1700010C")]
			public int playerUpCount
			{
				[Address(RVA = "0x27081C0", Offset = "0x27075C0", Length = "0x5B")]
				[Token(Token = "0x6000388")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000100")]
			public private PlayMode playMode
			{
				[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000379")]
				 get { } //Length: 4
				[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x600037A")]
				private set { } //Length: 4
			}

			[Token(Token = "0x1700010D")]
			public int powerUpCount
			{
				[Address(RVA = "0x2708220", Offset = "0x2707620", Length = "0x5B")]
				[Token(Token = "0x6000389")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000103")]
			public long round
			{
				[Address(RVA = "0x2708280", Offset = "0x2707680", Length = "0x2C")]
				[Token(Token = "0x600037D")]
				 get { } //Length: 44
			}

			[Token(Token = "0x17000104")]
			public long score
			{
				[Address(RVA = "0x27082B0", Offset = "0x27076B0", Length = "0x1D")]
				[Token(Token = "0x600037E")]
				 get { } //Length: 29
			}

			[Token(Token = "0x1700010E")]
			public int speedUpCount
			{
				[Address(RVA = "0x27082D0", Offset = "0x27076D0", Length = "0x5B")]
				[Token(Token = "0x600038A")]
				 get { } //Length: 91
			}

			[Token(Token = "0x17000102")]
			public long stage
			{
				[Address(RVA = "0x2708330", Offset = "0x2707730", Length = "0x1B")]
				[Token(Token = "0x600037C")]
				 get { } //Length: 27
			}

			[Address(RVA = "0x2707CA0", Offset = "0x27070A0", Length = "0xBC")]
			[Token(Token = "0x6000377")]
			public UpdateParams(StageInformation si, PlayerInformation pi, bool playerDeathsBonus, bool destructionRateBonus) { }

			[Address(RVA = "0x2707DB0", Offset = "0x27071B0", Length = "0x24")]
			[Token(Token = "0x6000381")]
			public long get_amberJewelCount() { }

			[Address(RVA = "0x2707DE0", Offset = "0x27071E0", Length = "0x5B")]
			[Token(Token = "0x600038D")]
			public int get_armBeamCount() { }

			[Address(RVA = "0x2707E40", Offset = "0x2707240", Length = "0x5B")]
			[Token(Token = "0x6000392")]
			public int get_armBlackCount() { }

			[Address(RVA = "0x2707EA0", Offset = "0x27072A0", Length = "0x5B")]
			[Token(Token = "0x6000391")]
			public int get_armGoldCount() { }

			[Address(RVA = "0x2707F00", Offset = "0x2707300", Length = "0x5B")]
			[Token(Token = "0x6000390")]
			public int get_armHormingCount() { }

			[Address(RVA = "0x2707F60", Offset = "0x2707360", Length = "0x5B")]
			[Token(Token = "0x600038E")]
			public int get_armLaserCount() { }

			[Address(RVA = "0x2707FC0", Offset = "0x27073C0", Length = "0x5B")]
			[Token(Token = "0x600038C")]
			public int get_armNormalCount() { }

			[Address(RVA = "0x2708020", Offset = "0x2707420", Length = "0x5B")]
			[Token(Token = "0x600038F")]
			public int get_armStarmineCount() { }

			[Address(RVA = "0x2708080", Offset = "0x2707480", Length = "0x5B")]
			[Token(Token = "0x600038B")]
			public int get_bombStockCount() { }

			[Address(RVA = "0x27080E0", Offset = "0x27074E0", Length = "0x1A")]
			[Token(Token = "0x6000386")]
			public int get_bossTime() { }

			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000384")]
			public int get_destructionRateBonusCount() { }

			[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
			[Token(Token = "0x6000393")]
			public bool get_isLoopFlag() { }

			[Address(RVA = "0x2708100", Offset = "0x2707500", Length = "0x58")]
			[Token(Token = "0x6000387")]
			public int get_p5000Count() { }

			[Address(RVA = "0x2708160", Offset = "0x2707560", Length = "0x23")]
			[Token(Token = "0x6000380")]
			public long get_pipiruCount() { }

			[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
			[Token(Token = "0x600037B")]
			public PlayActor get_playActor() { }

			[Address(RVA = "0x2708190", Offset = "0x2707590", Length = "0x2B")]
			[Token(Token = "0x600037F")]
			public long get_playedMSecounds() { }

			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000382")]
			public int get_playerDeathsBonusCount() { }

			[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
			[Token(Token = "0x6000378")]
			public int get_playerNo() { }

			[Address(RVA = "0x27081C0", Offset = "0x27075C0", Length = "0x5B")]
			[Token(Token = "0x6000388")]
			public int get_playerUpCount() { }

			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000379")]
			public PlayMode get_playMode() { }

			[Address(RVA = "0x2708220", Offset = "0x2707620", Length = "0x5B")]
			[Token(Token = "0x6000389")]
			public int get_powerUpCount() { }

			[Address(RVA = "0x2708280", Offset = "0x2707680", Length = "0x2C")]
			[Token(Token = "0x600037D")]
			public long get_round() { }

			[Address(RVA = "0x27082B0", Offset = "0x27076B0", Length = "0x1D")]
			[Token(Token = "0x600037E")]
			public long get_score() { }

			[Address(RVA = "0x27082D0", Offset = "0x27076D0", Length = "0x5B")]
			[Token(Token = "0x600038A")]
			public int get_speedUpCount() { }

			[Address(RVA = "0x2708330", Offset = "0x2707730", Length = "0x1B")]
			[Token(Token = "0x600037C")]
			public long get_stage() { }

			[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000385")]
			private void set_destructionRateBonusCount(int value) { }

			[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000383")]
			private void set_playerDeathsBonusCount(int value) { }

			[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600037A")]
			private void set_playMode(PlayMode value) { }

		}

		[Token(Token = "0x4000285")]
		private static readonly int MaxLocalRankins; //Field offset: 0x0
		[Token(Token = "0x4000286")]
		private const string _baseName = "stage"; //Field offset: 0x0
		[Token(Token = "0x4000287")]
		private const int _version_now = 100; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000281")]
		private Dictionary<PlayActor, Dictionary`2<PlayStage, Data>> _recordsStroy; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000282")]
		private Dictionary<PlayMode, Data> _recordsOther; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000283")]
		private HeartStarterData _recordsHeartStarter; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000284")]
		private ArenaData _recordsArena; //Field offset: 0x30

		[Token(Token = "0x170000FD")]
		protected virtual string BaseName
		{
			[Address(RVA = "0x26F97D0", Offset = "0x26F8BD0", Length = "0x2C")]
			[Token(Token = "0x6000374")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000FA")]
		public Data RecordsArcade
		{
			[Address(RVA = "0x26F9850", Offset = "0x26F8C50", Length = "0x49")]
			[Token(Token = "0x6000371")]
			 get { } //Length: 73
		}

		[Token(Token = "0x170000FB")]
		public Data RecordsArcadeInfinite
		{
			[Address(RVA = "0x26F9800", Offset = "0x26F8C00", Length = "0x49")]
			[Token(Token = "0x6000372")]
			 get { } //Length: 73
		}

		[Token(Token = "0x170000F9")]
		public ArenaData RecordsArena
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x600036D")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000F8")]
		public HeartStarterData RecordsHeartStarter
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x600036C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000F7")]
		public Dictionary<PlayMode, Data> RecordsOther
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x600036B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000F6")]
		public Dictionary<PlayActor, Dictionary`2<PlayStage, Data>> RecordsStory
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x600036A")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000FC")]
		public Data RecordsTeam
		{
			[Address(RVA = "0x26F98A0", Offset = "0x26F8CA0", Length = "0x49")]
			[Token(Token = "0x6000373")]
			 get { } //Length: 73
		}

		[Token(Token = "0x170000FE")]
		public virtual int Version_now
		{
			[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
			[Token(Token = "0x6000375")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x26F94D0", Offset = "0x26F88D0", Length = "0x71")]
		[IteratorStateMachine(typeof(<_allEnumerator>d__12))]
		[Token(Token = "0x6000366")]
		private IEnumerable<DataBase> _allEnumerator() { }

		[Address(RVA = "0x26F8FA0", Offset = "0x26F83A0", Length = "0x1CA")]
		[Token(Token = "0x6000363")]
		private void _InitializeArena() { }

		[Address(RVA = "0x26F9170", Offset = "0x26F8570", Length = "0xA3")]
		[Token(Token = "0x6000362")]
		private void _InitializeHeartStarter() { }

		[Address(RVA = "0x26F9220", Offset = "0x26F8620", Length = "0x110")]
		[Token(Token = "0x6000361")]
		private void _InitializeOther(PlayMode m) { }

		[Address(RVA = "0x26F9340", Offset = "0x26F8740", Length = "0x18C")]
		[Token(Token = "0x6000360")]
		private void _InitializeStory(PlayActor a, PlayStage s) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000369")]
		protected virtual void _postMigrate() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000368")]
		protected virtual void _preMigrate() { }

		[Address(RVA = "0x26F9550", Offset = "0x26F8950", Length = "0x39")]
		[Token(Token = "0x6000376")]
		private static Stages() { }

		[Address(RVA = "0x26F9590", Offset = "0x26F8990", Length = "0x233")]
		[Token(Token = "0x600035F")]
		public Stages() { }

		[Address(RVA = "0x26F8970", Offset = "0x26F7D70", Length = "0x71")]
		[IteratorStateMachine(typeof(<AllEnumerator>d__13))]
		[Token(Token = "0x6000367")]
		protected virtual IEnumerable<RecordValueBase> AllEnumerator() { }

		[Address(RVA = "0x26F89F0", Offset = "0x26F7DF0", Length = "0xCE")]
		[Token(Token = "0x6000364")]
		private Data GatStageData(PlayMode playMode, PlayActor playActor, PlayStage playStage) { }

		[Address(RVA = "0x26F97D0", Offset = "0x26F8BD0", Length = "0x2C")]
		[Token(Token = "0x6000374")]
		protected virtual string get_BaseName() { }

		[Address(RVA = "0x26F9850", Offset = "0x26F8C50", Length = "0x49")]
		[Token(Token = "0x6000371")]
		public Data get_RecordsArcade() { }

		[Address(RVA = "0x26F9800", Offset = "0x26F8C00", Length = "0x49")]
		[Token(Token = "0x6000372")]
		public Data get_RecordsArcadeInfinite() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600036D")]
		public ArenaData get_RecordsArena() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600036C")]
		public HeartStarterData get_RecordsHeartStarter() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600036B")]
		public Dictionary<PlayMode, Data> get_RecordsOther() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600036A")]
		public Dictionary<PlayActor, Dictionary`2<PlayStage, Data>> get_RecordsStory() { }

		[Address(RVA = "0x26F98A0", Offset = "0x26F8CA0", Length = "0x49")]
		[Token(Token = "0x6000373")]
		public Data get_RecordsTeam() { }

		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x6000375")]
		public virtual int get_Version_now() { }

		[Address(RVA = "0x26F8AC0", Offset = "0x26F7EC0", Length = "0x73")]
		[Token(Token = "0x600036E")]
		public Data RecordsStoryA(PlayStage ep) { }

		[Address(RVA = "0x26F8B40", Offset = "0x26F7F40", Length = "0x76")]
		[Token(Token = "0x600036F")]
		public Data RecordsStoryB(PlayStage ep) { }

		[Address(RVA = "0x26F8BC0", Offset = "0x26F7FC0", Length = "0x76")]
		[Token(Token = "0x6000370")]
		public Data RecordsStoryC(PlayStage ep) { }

		[Address(RVA = "0x26F8C40", Offset = "0x26F8040", Length = "0x35E")]
		[Token(Token = "0x6000365")]
		public bool Update(in UpdateParams param, bool isBossDestroy, bool isGameEnd, in DateTime updateDateTime, bool validTestFlg = false) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x200007A")]
	internal class Statistics : RecordsBase
	{
		[CompilerGenerated]
		[Token(Token = "0x2000080")]
		private sealed class <_allEnumerator>d__12 : IEnumerable<Data>, IEnumerable, IEnumerator<Data>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002FD")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002FE")]
			private Data <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40002FF")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000300")]
			public Statistics <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000301")]
			private Enumerator<Data> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x17000188")]
			private override Data System.Collections.Generic.IEnumerator<TXEKernel.PlayedRecords.Statistics.Data>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600048A")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000189")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600048C")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000486")]
			public <_allEnumerator>d__12(int <>1__state) { }

			[Address(RVA = "0x27067A0", Offset = "0x2705BA0", Length = "0x41")]
			[Token(Token = "0x6000489")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x2705CD0", Offset = "0x27050D0", Length = "0x1A9")]
			[Token(Token = "0x6000488")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2706420", Offset = "0x2705820", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600048D")]
			private override IEnumerator<Data> System.Collections.Generic.IEnumerable<TXEKernel.PlayedRecords.Statistics.Data>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600048A")]
			private override Data System.Collections.Generic.IEnumerator<TXEKernel.PlayedRecords.Statistics.Data>.get_Current() { }

			[Address(RVA = "0x2706420", Offset = "0x2705820", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x600048E")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600048C")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2706500", Offset = "0x2705900", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x600048B")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2706540", Offset = "0x2705940", Length = "0x83")]
			[DebuggerHidden]
			[Token(Token = "0x6000487")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007F")]
		private sealed class <AllEnumerator>d__13 : IEnumerable<RecordValueBase>, IEnumerable, IEnumerator<RecordValueBase>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002F8")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002F9")]
			private RecordValueBase <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40002FA")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40002FB")]
			public Statistics <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x40002FC")]
			private IEnumerator<Data> <>7__wrap1; //Field offset: 0x30

			[Token(Token = "0x17000186")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000481")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000187")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000483")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x600047D")]
			public <AllEnumerator>d__13(int <>1__state) { }

			[Address(RVA = "0x2701D90", Offset = "0x2701190", Length = "0x50")]
			[Token(Token = "0x6000480")]
			private void <>m__Finally1() { }

			[Address(RVA = "0x27013C0", Offset = "0x27007C0", Length = "0x1E5")]
			[Token(Token = "0x600047F")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2701A40", Offset = "0x2700E40", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000484")]
			private override IEnumerator<RecordValueBase> System.Collections.Generic.IEnumerable<TXEKernel.RecordValueBase>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000481")]
			private override RecordValueBase System.Collections.Generic.IEnumerator<TXEKernel.RecordValueBase>.get_Current() { }

			[Address(RVA = "0x2701A40", Offset = "0x2700E40", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000485")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000483")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2701AE0", Offset = "0x2700EE0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000482")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2701B60", Offset = "0x2700F60", Length = "0x8C")]
			[DebuggerHidden]
			[Token(Token = "0x600047E")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x200007D")]
		internal class Data : RecordClampedInt64
		{
			[Token(Token = "0x200007E")]
			internal class DataParams : ClampedValueParams<Int64>
			{
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x40002F7")]
				private readonly long _levelRate; //Field offset: 0x28

				[Token(Token = "0x17000185")]
				public long LevelRate
				{
					[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
					[Token(Token = "0x600047C")]
					 get { } //Length: 5
				}

				[Address(RVA = "0x26EF9B0", Offset = "0x26EEDB0", Length = "0xC0")]
				[Token(Token = "0x600047B")]
				public DataParams(Label label, long maxValue, long levelRate = 0) { }

				[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
				[Token(Token = "0x600047C")]
				public long get_LevelRate() { }

			}


			[Token(Token = "0x17000183")]
			public long Level
			{
				[Address(RVA = "0x26F0A50", Offset = "0x26EFE50", Length = "0x59")]
				[Token(Token = "0x6000479")]
				 get { } //Length: 89
			}

			[Token(Token = "0x17000184")]
			public long LevelRate
			{
				[Address(RVA = "0x26F09D0", Offset = "0x26EFDD0", Length = "0x71")]
				[Token(Token = "0x600047A")]
				 get { } //Length: 113
			}

			[Address(RVA = "0x26F08D0", Offset = "0x26EFCD0", Length = "0x48")]
			[Token(Token = "0x6000478")]
			public Data(DataParams p) { }

			[Address(RVA = "0x26F0A50", Offset = "0x26EFE50", Length = "0x59")]
			[Token(Token = "0x6000479")]
			public long get_Level() { }

			[Address(RVA = "0x26F09D0", Offset = "0x26EFDD0", Length = "0x71")]
			[Token(Token = "0x600047A")]
			public long get_LevelRate() { }

		}

		[Token(Token = "0x200007B")]
		internal enum Label : int
		{
			TotalScore = 0,
			TotalPlayTimeMSeconds = 1,
			TotalEnemiesDestroyCount = 2,
			TotalBossesDestroyCount = 3,
			TotalPlayerDeathsBonusCount = 4,
			TotalDestructionRateBonusCount = 5,
			TotalRemainingTime = 6,
			TotalPipirusCount = 7,
			TotalAmberJewelCount = 8,
			Total5000PCount = 9,
			Total1UpCount = 10,
			TotalPowerShotCount = 11,
			TotalTatsujinBeamCount = 12,
			TotalThunderLaserCount = 13,
			TotalHomingShotCount = 14,
			TotalStarmineShotCount = 15,
			TotalGoldThunderLaserCount = 16,
			TotalBlackThunderLaserCount = 17,
			TotalPItemCount = 18,
			TotalSItemCount = 19,
			TotalBombItemCount = 20,
			TotalMissCount = 21,
			TotalUseBomsCount = 22,
			PipirusLevelPrevViewed = 23,
		}

		[Token(Token = "0x200007C")]
		internal class UpdateParams
		{
			[CompilerGenerated]
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002F3")]
			private int <numDead>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x40002F4")]
			private int <numBomber>k__BackingField; //Field offset: 0x14
			[CompilerGenerated]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002F5")]
			private int <numDeadInStage>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x40002F6")]
			private int <numUseBomberInStage>k__BackingField; //Field offset: 0x1C

			[Token(Token = "0x17000180")]
			public private int numBomber
			{
				[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000472")]
				 get { } //Length: 4
				[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000473")]
				private set { } //Length: 4
			}

			[Token(Token = "0x1700017F")]
			public private int numDead
			{
				[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
				[CompilerGenerated]
				[Token(Token = "0x6000470")]
				 get { } //Length: 85
				[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000471")]
				private set { } //Length: 4
			}

			[Token(Token = "0x17000181")]
			public private int numDeadInStage
			{
				[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000474")]
				 get { } //Length: 4
				[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000475")]
				private set { } //Length: 4
			}

			[Token(Token = "0x17000182")]
			public private int numUseBomberInStage
			{
				[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000476")]
				 get { } //Length: 4
				[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x6000477")]
				private set { } //Length: 4
			}

			[Address(RVA = "0x2707D60", Offset = "0x2707160", Length = "0x44")]
			[Token(Token = "0x600046F")]
			public UpdateParams(PlayerInformation pi) { }

			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000472")]
			public int get_numBomber() { }

			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x6000470")]
			public int get_numDead() { }

			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000474")]
			public int get_numDeadInStage() { }

			[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000476")]
			public int get_numUseBomberInStage() { }

			[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000473")]
			private void set_numBomber(int value) { }

			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000471")]
			private void set_numDead(int value) { }

			[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000475")]
			private void set_numDeadInStage(int value) { }

			[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000477")]
			private void set_numUseBomberInStage(int value) { }

		}

		[Token(Token = "0x40002D8")]
		private const string _baseName = "STATISTICS"; //Field offset: 0x0
		[Token(Token = "0x40002D9")]
		private const int _version_now = 100; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002D5")]
		private readonly DataParams[] recordValueParams; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002D6")]
		private List<Data> _records; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002D7")]
		public readonly long PipiruLevelDivValue; //Field offset: 0x28

		[Token(Token = "0x1700017D")]
		protected virtual string BaseName
		{
			[Address(RVA = "0x26FAD80", Offset = "0x26FA180", Length = "0x2C")]
			[Token(Token = "0x600046D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700014C")]
		public Data Item
		{
			[Address(RVA = "0x26FADB0", Offset = "0x26FA1B0", Length = "0x51")]
			[Token(Token = "0x6000424")]
			 get { } //Length: 81
		}

		[Token(Token = "0x17000164")]
		public Data PipirusLevelPrevViewed
		{
			[Address(RVA = "0x26FAE80", Offset = "0x26FA280", Length = "0x49")]
			[Token(Token = "0x600043C")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700017C")]
		public int PipirusLevelPrevViewedValue
		{
			[Address(RVA = "0x26FAE10", Offset = "0x26FA210", Length = "0x65")]
			[Token(Token = "0x600046B")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC010", Offset = "0x26FB410", Length = "0x74")]
			[Token(Token = "0x600046C")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700014B")]
		public List<Data> Records
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000423")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000157")]
		public Data Total1UpCount
		{
			[Address(RVA = "0x26FAF40", Offset = "0x26FA340", Length = "0x49")]
			[Token(Token = "0x600042F")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700016F")]
		public long Total1UpCountValue
		{
			[Address(RVA = "0x26FAED0", Offset = "0x26FA2D0", Length = "0x65")]
			[Token(Token = "0x6000451")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC090", Offset = "0x26FB490", Length = "0x74")]
			[Token(Token = "0x6000452")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000156")]
		public Data Total5000PCount
		{
			[Address(RVA = "0x26FB000", Offset = "0x26FA400", Length = "0x49")]
			[Token(Token = "0x600042E")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700016E")]
		public long Total5000PCountValue
		{
			[Address(RVA = "0x26FAF90", Offset = "0x26FA390", Length = "0x65")]
			[Token(Token = "0x600044F")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC110", Offset = "0x26FB510", Length = "0x74")]
			[Token(Token = "0x6000450")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000155")]
		public Data TotalAmberJewelCount
		{
			[Address(RVA = "0x26FB0C0", Offset = "0x26FA4C0", Length = "0x49")]
			[Token(Token = "0x600042D")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700016D")]
		public long TotalAmberJewelCountValue
		{
			[Address(RVA = "0x26FB050", Offset = "0x26FA450", Length = "0x65")]
			[Token(Token = "0x600044D")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC190", Offset = "0x26FB590", Length = "0x74")]
			[Token(Token = "0x600044E")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700015E")]
		public Data TotalBlackThunderLaserCount
		{
			[Address(RVA = "0x26FB180", Offset = "0x26FA580", Length = "0x49")]
			[Token(Token = "0x6000436")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000176")]
		public long TotalBlackThunderLaserCountValue
		{
			[Address(RVA = "0x26FB110", Offset = "0x26FA510", Length = "0x65")]
			[Token(Token = "0x600045F")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC210", Offset = "0x26FB610", Length = "0x74")]
			[Token(Token = "0x6000460")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000161")]
		public Data TotalBombItemCount
		{
			[Address(RVA = "0x26FB240", Offset = "0x26FA640", Length = "0x49")]
			[Token(Token = "0x6000439")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000179")]
		public long TotalBombItemCountValue
		{
			[Address(RVA = "0x26FB1D0", Offset = "0x26FA5D0", Length = "0x65")]
			[Token(Token = "0x6000465")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC290", Offset = "0x26FB690", Length = "0x74")]
			[Token(Token = "0x6000466")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000150")]
		public Data TotalBossesDestroyCount
		{
			[Address(RVA = "0x26FB300", Offset = "0x26FA700", Length = "0x49")]
			[Token(Token = "0x6000428")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000168")]
		public long TotalBossesDestroyCountValue
		{
			[Address(RVA = "0x26FB290", Offset = "0x26FA690", Length = "0x65")]
			[Token(Token = "0x6000443")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC310", Offset = "0x26FB710", Length = "0x74")]
			[Token(Token = "0x6000444")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000152")]
		public Data TotalDestructionRateBonusCount
		{
			[Address(RVA = "0x26FB3C0", Offset = "0x26FA7C0", Length = "0x49")]
			[Token(Token = "0x600042A")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700016A")]
		public long TotalDestructionRateBonusCountValue
		{
			[Address(RVA = "0x26FB350", Offset = "0x26FA750", Length = "0x65")]
			[Token(Token = "0x6000447")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC390", Offset = "0x26FB790", Length = "0x74")]
			[Token(Token = "0x6000448")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700014F")]
		public Data TotalEnemiesDestroyCount
		{
			[Address(RVA = "0x26FB480", Offset = "0x26FA880", Length = "0x49")]
			[Token(Token = "0x6000427")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000167")]
		public long TotalEnemiesDestroyCountValue
		{
			[Address(RVA = "0x26FB410", Offset = "0x26FA810", Length = "0x65")]
			[Token(Token = "0x6000441")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC410", Offset = "0x26FB810", Length = "0x74")]
			[Token(Token = "0x6000442")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700015D")]
		public Data TotalGoldThunderLaserCount
		{
			[Address(RVA = "0x26FB540", Offset = "0x26FA940", Length = "0x49")]
			[Token(Token = "0x6000435")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000175")]
		public long TotalGoldThunderLaserCountValue
		{
			[Address(RVA = "0x26FB4D0", Offset = "0x26FA8D0", Length = "0x65")]
			[Token(Token = "0x600045D")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC490", Offset = "0x26FB890", Length = "0x74")]
			[Token(Token = "0x600045E")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700015B")]
		public Data TotalHomingShotCount
		{
			[Address(RVA = "0x26FB600", Offset = "0x26FAA00", Length = "0x49")]
			[Token(Token = "0x6000433")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000173")]
		public long TotalHomingShotCountValue
		{
			[Address(RVA = "0x26FB590", Offset = "0x26FA990", Length = "0x65")]
			[Token(Token = "0x6000459")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC510", Offset = "0x26FB910", Length = "0x74")]
			[Token(Token = "0x600045A")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000162")]
		public Data TotalMissCount
		{
			[Address(RVA = "0x26FB6C0", Offset = "0x26FAAC0", Length = "0x49")]
			[Token(Token = "0x600043A")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700017A")]
		public long TotalMissCountValue
		{
			[Address(RVA = "0x26FB650", Offset = "0x26FAA50", Length = "0x65")]
			[Token(Token = "0x6000467")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC590", Offset = "0x26FB990", Length = "0x74")]
			[Token(Token = "0x6000468")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000154")]
		public Data TotalPipirusCount
		{
			[Address(RVA = "0x26FB840", Offset = "0x26FAC40", Length = "0x49")]
			[Token(Token = "0x600042C")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700016C")]
		public long TotalPipirusCountValue
		{
			[Address(RVA = "0x26FB7D0", Offset = "0x26FABD0", Length = "0x65")]
			[Token(Token = "0x600044B")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC690", Offset = "0x26FBA90", Length = "0x74")]
			[Token(Token = "0x600044C")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700015F")]
		public Data TotalPItemCount
		{
			[Address(RVA = "0x26FB780", Offset = "0x26FAB80", Length = "0x49")]
			[Token(Token = "0x6000437")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000177")]
		public long TotalPItemCountValue
		{
			[Address(RVA = "0x26FB710", Offset = "0x26FAB10", Length = "0x65")]
			[Token(Token = "0x6000461")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC610", Offset = "0x26FBA10", Length = "0x74")]
			[Token(Token = "0x6000462")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000151")]
		public Data TotalPlayerDeathsBonusCount
		{
			[Address(RVA = "0x26FB9C0", Offset = "0x26FADC0", Length = "0x49")]
			[Token(Token = "0x6000429")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000169")]
		public long TotalPlayerDeathsBonusCountValue
		{
			[Address(RVA = "0x26FB950", Offset = "0x26FAD50", Length = "0x65")]
			[Token(Token = "0x6000445")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC790", Offset = "0x26FBB90", Length = "0x74")]
			[Token(Token = "0x6000446")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700014E")]
		public Data TotalPlayTimeMSeconds
		{
			[Address(RVA = "0x26FB900", Offset = "0x26FAD00", Length = "0x49")]
			[Token(Token = "0x6000426")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000166")]
		public long TotalPlayTimeMSecondsValue
		{
			[Address(RVA = "0x26FB890", Offset = "0x26FAC90", Length = "0x65")]
			[Token(Token = "0x600043F")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC710", Offset = "0x26FBB10", Length = "0x74")]
			[Token(Token = "0x6000440")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000158")]
		public Data TotalPowerShotCount
		{
			[Address(RVA = "0x26FBA80", Offset = "0x26FAE80", Length = "0x49")]
			[Token(Token = "0x6000430")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000170")]
		public long TotalPowerShotCountValue
		{
			[Address(RVA = "0x26FBA10", Offset = "0x26FAE10", Length = "0x65")]
			[Token(Token = "0x6000453")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC810", Offset = "0x26FBC10", Length = "0x74")]
			[Token(Token = "0x6000454")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000153")]
		public Data TotalRemainingTime
		{
			[Address(RVA = "0x26FBB40", Offset = "0x26FAF40", Length = "0x49")]
			[Token(Token = "0x600042B")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700016B")]
		public long TotalRemainingTimeValue
		{
			[Address(RVA = "0x26FBAD0", Offset = "0x26FAED0", Length = "0x65")]
			[Token(Token = "0x6000449")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC890", Offset = "0x26FBC90", Length = "0x74")]
			[Token(Token = "0x600044A")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700014D")]
		public Data TotalScore
		{
			[Address(RVA = "0x26FBCC0", Offset = "0x26FB0C0", Length = "0x46")]
			[Token(Token = "0x6000425")]
			 get { } //Length: 70
		}

		[Token(Token = "0x17000165")]
		public long TotalScoreValue
		{
			[Address(RVA = "0x26FBC50", Offset = "0x26FB050", Length = "0x62")]
			[Token(Token = "0x600043D")]
			 get { } //Length: 98
			[Address(RVA = "0x26FC990", Offset = "0x26FBD90", Length = "0x71")]
			[Token(Token = "0x600043E")]
			 set { } //Length: 113
		}

		[Token(Token = "0x17000160")]
		public Data TotalSItemCount
		{
			[Address(RVA = "0x26FBC00", Offset = "0x26FB000", Length = "0x49")]
			[Token(Token = "0x6000438")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000178")]
		public long TotalSItemCountValue
		{
			[Address(RVA = "0x26FBB90", Offset = "0x26FAF90", Length = "0x65")]
			[Token(Token = "0x6000463")]
			 get { } //Length: 101
			[Address(RVA = "0x26FC910", Offset = "0x26FBD10", Length = "0x74")]
			[Token(Token = "0x6000464")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700015C")]
		public Data TotalStarmineShotCount
		{
			[Address(RVA = "0x26FBD80", Offset = "0x26FB180", Length = "0x49")]
			[Token(Token = "0x6000434")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000174")]
		public long TotalStarmineShotCountValue
		{
			[Address(RVA = "0x26FBD10", Offset = "0x26FB110", Length = "0x65")]
			[Token(Token = "0x600045B")]
			 get { } //Length: 101
			[Address(RVA = "0x26FCA10", Offset = "0x26FBE10", Length = "0x74")]
			[Token(Token = "0x600045C")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000159")]
		public Data TotalTatsujinBeamCount
		{
			[Address(RVA = "0x26FBE40", Offset = "0x26FB240", Length = "0x49")]
			[Token(Token = "0x6000431")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000171")]
		public long TotalTatsujinBeamCountValue
		{
			[Address(RVA = "0x26FBDD0", Offset = "0x26FB1D0", Length = "0x65")]
			[Token(Token = "0x6000455")]
			 get { } //Length: 101
			[Address(RVA = "0x26FCA90", Offset = "0x26FBE90", Length = "0x74")]
			[Token(Token = "0x6000456")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700015A")]
		public Data TotalThunderLaserCount
		{
			[Address(RVA = "0x26FBF00", Offset = "0x26FB300", Length = "0x49")]
			[Token(Token = "0x6000432")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000172")]
		public long TotalThunderLaserCountValue
		{
			[Address(RVA = "0x26FBE90", Offset = "0x26FB290", Length = "0x65")]
			[Token(Token = "0x6000457")]
			 get { } //Length: 101
			[Address(RVA = "0x26FCB10", Offset = "0x26FBF10", Length = "0x74")]
			[Token(Token = "0x6000458")]
			 set { } //Length: 116
		}

		[Token(Token = "0x17000163")]
		public Data TotalUseBomsCount
		{
			[Address(RVA = "0x26FBFC0", Offset = "0x26FB3C0", Length = "0x49")]
			[Token(Token = "0x600043B")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700017B")]
		public long TotalUseBomsCountValue
		{
			[Address(RVA = "0x26FBF50", Offset = "0x26FB350", Length = "0x65")]
			[Token(Token = "0x6000469")]
			 get { } //Length: 101
			[Address(RVA = "0x26FCB90", Offset = "0x26FBF90", Length = "0x74")]
			[Token(Token = "0x600046A")]
			 set { } //Length: 116
		}

		[Token(Token = "0x1700017E")]
		public virtual int Version_now
		{
			[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
			[Token(Token = "0x600046E")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x26FA020", Offset = "0x26F9420", Length = "0x71")]
		[IteratorStateMachine(typeof(<_allEnumerator>d__12))]
		[Token(Token = "0x600041F")]
		protected IEnumerable<Data> _allEnumerator() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000422")]
		protected virtual void _postMigrate() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000421")]
		protected virtual void _preMigrate() { }

		[Address(RVA = "0x26FA0A0", Offset = "0x26F94A0", Length = "0xCC1")]
		[Token(Token = "0x6000417")]
		public Statistics() { }

		[Address(RVA = "0x26F98F0", Offset = "0x26F8CF0", Length = "0x71")]
		[IteratorStateMachine(typeof(<AllEnumerator>d__13))]
		[Token(Token = "0x6000420")]
		protected virtual IEnumerable<RecordValueBase> AllEnumerator() { }

		[Address(RVA = "0x26FAD70", Offset = "0x26FA170", Length = "0xA")]
		[Token(Token = "0x600041C")]
		public int calcPipiruLevel(long num) { }

		[Address(RVA = "0x26FAD80", Offset = "0x26FA180", Length = "0x2C")]
		[Token(Token = "0x600046D")]
		protected virtual string get_BaseName() { }

		[Address(RVA = "0x26FADB0", Offset = "0x26FA1B0", Length = "0x51")]
		[Token(Token = "0x6000424")]
		public Data get_Item(Label idx) { }

		[Address(RVA = "0x26FAE80", Offset = "0x26FA280", Length = "0x49")]
		[Token(Token = "0x600043C")]
		public Data get_PipirusLevelPrevViewed() { }

		[Address(RVA = "0x26FAE10", Offset = "0x26FA210", Length = "0x65")]
		[Token(Token = "0x600046B")]
		public int get_PipirusLevelPrevViewedValue() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000423")]
		public List<Data> get_Records() { }

		[Address(RVA = "0x26FAF40", Offset = "0x26FA340", Length = "0x49")]
		[Token(Token = "0x600042F")]
		public Data get_Total1UpCount() { }

		[Address(RVA = "0x26FAED0", Offset = "0x26FA2D0", Length = "0x65")]
		[Token(Token = "0x6000451")]
		public long get_Total1UpCountValue() { }

		[Address(RVA = "0x26FB000", Offset = "0x26FA400", Length = "0x49")]
		[Token(Token = "0x600042E")]
		public Data get_Total5000PCount() { }

		[Address(RVA = "0x26FAF90", Offset = "0x26FA390", Length = "0x65")]
		[Token(Token = "0x600044F")]
		public long get_Total5000PCountValue() { }

		[Address(RVA = "0x26FB0C0", Offset = "0x26FA4C0", Length = "0x49")]
		[Token(Token = "0x600042D")]
		public Data get_TotalAmberJewelCount() { }

		[Address(RVA = "0x26FB050", Offset = "0x26FA450", Length = "0x65")]
		[Token(Token = "0x600044D")]
		public long get_TotalAmberJewelCountValue() { }

		[Address(RVA = "0x26FB180", Offset = "0x26FA580", Length = "0x49")]
		[Token(Token = "0x6000436")]
		public Data get_TotalBlackThunderLaserCount() { }

		[Address(RVA = "0x26FB110", Offset = "0x26FA510", Length = "0x65")]
		[Token(Token = "0x600045F")]
		public long get_TotalBlackThunderLaserCountValue() { }

		[Address(RVA = "0x26FB240", Offset = "0x26FA640", Length = "0x49")]
		[Token(Token = "0x6000439")]
		public Data get_TotalBombItemCount() { }

		[Address(RVA = "0x26FB1D0", Offset = "0x26FA5D0", Length = "0x65")]
		[Token(Token = "0x6000465")]
		public long get_TotalBombItemCountValue() { }

		[Address(RVA = "0x26FB300", Offset = "0x26FA700", Length = "0x49")]
		[Token(Token = "0x6000428")]
		public Data get_TotalBossesDestroyCount() { }

		[Address(RVA = "0x26FB290", Offset = "0x26FA690", Length = "0x65")]
		[Token(Token = "0x6000443")]
		public long get_TotalBossesDestroyCountValue() { }

		[Address(RVA = "0x26FB3C0", Offset = "0x26FA7C0", Length = "0x49")]
		[Token(Token = "0x600042A")]
		public Data get_TotalDestructionRateBonusCount() { }

		[Address(RVA = "0x26FB350", Offset = "0x26FA750", Length = "0x65")]
		[Token(Token = "0x6000447")]
		public long get_TotalDestructionRateBonusCountValue() { }

		[Address(RVA = "0x26FB480", Offset = "0x26FA880", Length = "0x49")]
		[Token(Token = "0x6000427")]
		public Data get_TotalEnemiesDestroyCount() { }

		[Address(RVA = "0x26FB410", Offset = "0x26FA810", Length = "0x65")]
		[Token(Token = "0x6000441")]
		public long get_TotalEnemiesDestroyCountValue() { }

		[Address(RVA = "0x26FB540", Offset = "0x26FA940", Length = "0x49")]
		[Token(Token = "0x6000435")]
		public Data get_TotalGoldThunderLaserCount() { }

		[Address(RVA = "0x26FB4D0", Offset = "0x26FA8D0", Length = "0x65")]
		[Token(Token = "0x600045D")]
		public long get_TotalGoldThunderLaserCountValue() { }

		[Address(RVA = "0x26FB600", Offset = "0x26FAA00", Length = "0x49")]
		[Token(Token = "0x6000433")]
		public Data get_TotalHomingShotCount() { }

		[Address(RVA = "0x26FB590", Offset = "0x26FA990", Length = "0x65")]
		[Token(Token = "0x6000459")]
		public long get_TotalHomingShotCountValue() { }

		[Address(RVA = "0x26FB6C0", Offset = "0x26FAAC0", Length = "0x49")]
		[Token(Token = "0x600043A")]
		public Data get_TotalMissCount() { }

		[Address(RVA = "0x26FB650", Offset = "0x26FAA50", Length = "0x65")]
		[Token(Token = "0x6000467")]
		public long get_TotalMissCountValue() { }

		[Address(RVA = "0x26FB840", Offset = "0x26FAC40", Length = "0x49")]
		[Token(Token = "0x600042C")]
		public Data get_TotalPipirusCount() { }

		[Address(RVA = "0x26FB7D0", Offset = "0x26FABD0", Length = "0x65")]
		[Token(Token = "0x600044B")]
		public long get_TotalPipirusCountValue() { }

		[Address(RVA = "0x26FB780", Offset = "0x26FAB80", Length = "0x49")]
		[Token(Token = "0x6000437")]
		public Data get_TotalPItemCount() { }

		[Address(RVA = "0x26FB710", Offset = "0x26FAB10", Length = "0x65")]
		[Token(Token = "0x6000461")]
		public long get_TotalPItemCountValue() { }

		[Address(RVA = "0x26FB9C0", Offset = "0x26FADC0", Length = "0x49")]
		[Token(Token = "0x6000429")]
		public Data get_TotalPlayerDeathsBonusCount() { }

		[Address(RVA = "0x26FB950", Offset = "0x26FAD50", Length = "0x65")]
		[Token(Token = "0x6000445")]
		public long get_TotalPlayerDeathsBonusCountValue() { }

		[Address(RVA = "0x26FB900", Offset = "0x26FAD00", Length = "0x49")]
		[Token(Token = "0x6000426")]
		public Data get_TotalPlayTimeMSeconds() { }

		[Address(RVA = "0x26FB890", Offset = "0x26FAC90", Length = "0x65")]
		[Token(Token = "0x600043F")]
		public long get_TotalPlayTimeMSecondsValue() { }

		[Address(RVA = "0x26FBA80", Offset = "0x26FAE80", Length = "0x49")]
		[Token(Token = "0x6000430")]
		public Data get_TotalPowerShotCount() { }

		[Address(RVA = "0x26FBA10", Offset = "0x26FAE10", Length = "0x65")]
		[Token(Token = "0x6000453")]
		public long get_TotalPowerShotCountValue() { }

		[Address(RVA = "0x26FBB40", Offset = "0x26FAF40", Length = "0x49")]
		[Token(Token = "0x600042B")]
		public Data get_TotalRemainingTime() { }

		[Address(RVA = "0x26FBAD0", Offset = "0x26FAED0", Length = "0x65")]
		[Token(Token = "0x6000449")]
		public long get_TotalRemainingTimeValue() { }

		[Address(RVA = "0x26FBCC0", Offset = "0x26FB0C0", Length = "0x46")]
		[Token(Token = "0x6000425")]
		public Data get_TotalScore() { }

		[Address(RVA = "0x26FBC50", Offset = "0x26FB050", Length = "0x62")]
		[Token(Token = "0x600043D")]
		public long get_TotalScoreValue() { }

		[Address(RVA = "0x26FBC00", Offset = "0x26FB000", Length = "0x49")]
		[Token(Token = "0x6000438")]
		public Data get_TotalSItemCount() { }

		[Address(RVA = "0x26FBB90", Offset = "0x26FAF90", Length = "0x65")]
		[Token(Token = "0x6000463")]
		public long get_TotalSItemCountValue() { }

		[Address(RVA = "0x26FBD80", Offset = "0x26FB180", Length = "0x49")]
		[Token(Token = "0x6000434")]
		public Data get_TotalStarmineShotCount() { }

		[Address(RVA = "0x26FBD10", Offset = "0x26FB110", Length = "0x65")]
		[Token(Token = "0x600045B")]
		public long get_TotalStarmineShotCountValue() { }

		[Address(RVA = "0x26FBE40", Offset = "0x26FB240", Length = "0x49")]
		[Token(Token = "0x6000431")]
		public Data get_TotalTatsujinBeamCount() { }

		[Address(RVA = "0x26FBDD0", Offset = "0x26FB1D0", Length = "0x65")]
		[Token(Token = "0x6000455")]
		public long get_TotalTatsujinBeamCountValue() { }

		[Address(RVA = "0x26FBF00", Offset = "0x26FB300", Length = "0x49")]
		[Token(Token = "0x6000432")]
		public Data get_TotalThunderLaserCount() { }

		[Address(RVA = "0x26FBE90", Offset = "0x26FB290", Length = "0x65")]
		[Token(Token = "0x6000457")]
		public long get_TotalThunderLaserCountValue() { }

		[Address(RVA = "0x26FBFC0", Offset = "0x26FB3C0", Length = "0x49")]
		[Token(Token = "0x600043B")]
		public Data get_TotalUseBomsCount() { }

		[Address(RVA = "0x26FBF50", Offset = "0x26FB350", Length = "0x65")]
		[Token(Token = "0x6000469")]
		public long get_TotalUseBomsCountValue() { }

		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x600046E")]
		public virtual int get_Version_now() { }

		[Address(RVA = "0x26F9970", Offset = "0x26F8D70", Length = "0xDC")]
		[Token(Token = "0x600041A")]
		public bool IsNewPipiruLevel() { }

		[Address(RVA = "0x26F9A50", Offset = "0x26F8E50", Length = "0x6C")]
		[Token(Token = "0x600041D")]
		public int PipiruLevelNow() { }

		[Address(RVA = "0x26F9AC0", Offset = "0x26F8EC0", Length = "0x80")]
		[Token(Token = "0x600041E")]
		public int PipiruLevelPrev() { }

		[Address(RVA = "0x26F9B50", Offset = "0x26F8F50", Length = "0x229")]
		[Token(Token = "0x6000419")]
		public long PlayerLevel() { }

		[Address(RVA = "0x26FC010", Offset = "0x26FB410", Length = "0x74")]
		[Token(Token = "0x600046C")]
		public void set_PipirusLevelPrevViewedValue(int value) { }

		[Address(RVA = "0x26FC090", Offset = "0x26FB490", Length = "0x74")]
		[Token(Token = "0x6000452")]
		public void set_Total1UpCountValue(long value) { }

		[Address(RVA = "0x26FC110", Offset = "0x26FB510", Length = "0x74")]
		[Token(Token = "0x6000450")]
		public void set_Total5000PCountValue(long value) { }

		[Address(RVA = "0x26FC190", Offset = "0x26FB590", Length = "0x74")]
		[Token(Token = "0x600044E")]
		public void set_TotalAmberJewelCountValue(long value) { }

		[Address(RVA = "0x26FC210", Offset = "0x26FB610", Length = "0x74")]
		[Token(Token = "0x6000460")]
		public void set_TotalBlackThunderLaserCountValue(long value) { }

		[Address(RVA = "0x26FC290", Offset = "0x26FB690", Length = "0x74")]
		[Token(Token = "0x6000466")]
		public void set_TotalBombItemCountValue(long value) { }

		[Address(RVA = "0x26FC310", Offset = "0x26FB710", Length = "0x74")]
		[Token(Token = "0x6000444")]
		public void set_TotalBossesDestroyCountValue(long value) { }

		[Address(RVA = "0x26FC390", Offset = "0x26FB790", Length = "0x74")]
		[Token(Token = "0x6000448")]
		public void set_TotalDestructionRateBonusCountValue(long value) { }

		[Address(RVA = "0x26FC410", Offset = "0x26FB810", Length = "0x74")]
		[Token(Token = "0x6000442")]
		public void set_TotalEnemiesDestroyCountValue(long value) { }

		[Address(RVA = "0x26FC490", Offset = "0x26FB890", Length = "0x74")]
		[Token(Token = "0x600045E")]
		public void set_TotalGoldThunderLaserCountValue(long value) { }

		[Address(RVA = "0x26FC510", Offset = "0x26FB910", Length = "0x74")]
		[Token(Token = "0x600045A")]
		public void set_TotalHomingShotCountValue(long value) { }

		[Address(RVA = "0x26FC590", Offset = "0x26FB990", Length = "0x74")]
		[Token(Token = "0x6000468")]
		public void set_TotalMissCountValue(long value) { }

		[Address(RVA = "0x26FC690", Offset = "0x26FBA90", Length = "0x74")]
		[Token(Token = "0x600044C")]
		public void set_TotalPipirusCountValue(long value) { }

		[Address(RVA = "0x26FC610", Offset = "0x26FBA10", Length = "0x74")]
		[Token(Token = "0x6000462")]
		public void set_TotalPItemCountValue(long value) { }

		[Address(RVA = "0x26FC790", Offset = "0x26FBB90", Length = "0x74")]
		[Token(Token = "0x6000446")]
		public void set_TotalPlayerDeathsBonusCountValue(long value) { }

		[Address(RVA = "0x26FC710", Offset = "0x26FBB10", Length = "0x74")]
		[Token(Token = "0x6000440")]
		public void set_TotalPlayTimeMSecondsValue(long value) { }

		[Address(RVA = "0x26FC810", Offset = "0x26FBC10", Length = "0x74")]
		[Token(Token = "0x6000454")]
		public void set_TotalPowerShotCountValue(long value) { }

		[Address(RVA = "0x26FC890", Offset = "0x26FBC90", Length = "0x74")]
		[Token(Token = "0x600044A")]
		public void set_TotalRemainingTimeValue(long value) { }

		[Address(RVA = "0x26FC990", Offset = "0x26FBD90", Length = "0x71")]
		[Token(Token = "0x600043E")]
		public void set_TotalScoreValue(long value) { }

		[Address(RVA = "0x26FC910", Offset = "0x26FBD10", Length = "0x74")]
		[Token(Token = "0x6000464")]
		public void set_TotalSItemCountValue(long value) { }

		[Address(RVA = "0x26FCA10", Offset = "0x26FBE10", Length = "0x74")]
		[Token(Token = "0x600045C")]
		public void set_TotalStarmineShotCountValue(long value) { }

		[Address(RVA = "0x26FCA90", Offset = "0x26FBE90", Length = "0x74")]
		[Token(Token = "0x6000456")]
		public void set_TotalTatsujinBeamCountValue(long value) { }

		[Address(RVA = "0x26FCB10", Offset = "0x26FBF10", Length = "0x74")]
		[Token(Token = "0x6000458")]
		public void set_TotalThunderLaserCountValue(long value) { }

		[Address(RVA = "0x26FCB90", Offset = "0x26FBF90", Length = "0x74")]
		[Token(Token = "0x600046A")]
		public void set_TotalUseBomsCountValue(long value) { }

		[Address(RVA = "0x26F9D80", Offset = "0x26F9180", Length = "0xD1")]
		[Token(Token = "0x600041B")]
		public void SetViewedPipiruLevel() { }

		[Address(RVA = "0x26F9E60", Offset = "0x26F9260", Length = "0x1BD")]
		[Token(Token = "0x6000418")]
		public bool Update(in UpdateParams param, bool isBossDestroy, bool isGameEnd) { }

	}

	[Token(Token = "0x2000058")]
	internal class UpdateParam
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400022D")]
		private UpdateParams <stages>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400022E")]
		private UpdateParams <statistics>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400022F")]
		private Dictionary<String, Int32> <EnemyDestoryed>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000230")]
		private bool <IsBossDestroy>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x4000231")]
		private bool <IsGameEnd>k__BackingField; //Field offset: 0x29

		[Token(Token = "0x170000A1")]
		public private Dictionary<String, Int32> EnemyDestoryed
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600029A")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600029B")]
			private set { } //Length: 13
		}

		[Token(Token = "0x170000A2")]
		public private bool IsBossDestroy
		{
			[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600029C")]
			 get { } //Length: 5
			[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600029D")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170000A3")]
		public private bool IsGameEnd
		{
			[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600029E")]
			 get { } //Length: 5
			[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600029F")]
			private set { } //Length: 4
		}

		[Token(Token = "0x1700009F")]
		public private UpdateParams stages
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000296")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000297")]
			private set { } //Length: 13
		}

		[Token(Token = "0x170000A0")]
		public private UpdateParams statistics
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000298")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000299")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x2707AE0", Offset = "0x2706EE0", Length = "0x1A4")]
		[Token(Token = "0x6000295")]
		public UpdateParam(StageInformation stageInformation, PlayerInformation playerInformation, bool playerDeathsBonus, bool destructionRateBonus) { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600029A")]
		public Dictionary<String, Int32> get_EnemyDestoryed() { }

		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600029C")]
		public bool get_IsBossDestroy() { }

		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600029E")]
		public bool get_IsGameEnd() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000296")]
		public UpdateParams get_stages() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000298")]
		public UpdateParams get_statistics() { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600029B")]
		private void set_EnemyDestoryed(Dictionary<String, Int32> value) { }

		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600029D")]
		private void set_IsBossDestroy(bool value) { }

		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600029F")]
		private void set_IsGameEnd(bool value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000297")]
		private void set_stages(UpdateParams value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000299")]
		private void set_statistics(UpdateParams value) { }

	}

	[Token(Token = "0x400022B")]
	public static DateTime DefaultDateTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000226")]
	private General _general; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000227")]
	private Statistics _statistics; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000228")]
	private Stages _stages; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000229")]
	private Enemies _enemies; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400022A")]
	private Achievement _achievement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022C")]
	private List<String> _unlockItemsText; //Field offset: 0x38

	[Token(Token = "0x1700009D")]
	public Achievement achievement
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000292")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009C")]
	public Enemies enemies
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000291")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000099")]
	public General general
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600028E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000098")]
	public bool IsPipiruPlanetUnlocked
	{
		[Address(RVA = "0x26F5F90", Offset = "0x26F5390", Length = "0x5E")]
		[Token(Token = "0x600028B")]
		 get { } //Length: 94
	}

	[Token(Token = "0x1700009B")]
	public Stages stages
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000290")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009A")]
	public Statistics statistics
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600028F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009E")]
	public List<String> UnlockItemsText
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000293")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x26F5BF0", Offset = "0x26F4FF0", Length = "0x6C")]
	[Token(Token = "0x6000294")]
	private static PlayedRecords() { }

	[Address(RVA = "0x26F5C60", Offset = "0x26F5060", Length = "0x32E")]
	[Token(Token = "0x600027C")]
	public PlayedRecords() { }

	[Address(RVA = "0x26F4E80", Offset = "0x26F4280", Length = "0xA4")]
	[Token(Token = "0x6000284")]
	public void CompleteReset() { }

	[Address(RVA = "0x26F4F30", Offset = "0x26F4330", Length = "0x11F")]
	[Token(Token = "0x6000280")]
	public void EvaluateRecords(PlayMode playMode) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000292")]
	public Achievement get_achievement() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000291")]
	public Enemies get_enemies() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600028E")]
	public General get_general() { }

	[Address(RVA = "0x26F5F90", Offset = "0x26F5390", Length = "0x5E")]
	[Token(Token = "0x600028B")]
	public bool get_IsPipiruPlanetUnlocked() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000290")]
	public Stages get_stages() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600028F")]
	public Statistics get_statistics() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000293")]
	public List<String> get_UnlockItemsText() { }

	[Address(RVA = "0x26F5050", Offset = "0x26F4450", Length = "0x67")]
	[IteratorStateMachine(typeof(<Initialize>d__2))]
	[Token(Token = "0x600027D")]
	public IEnumerator Initialize() { }

	[Address(RVA = "0x26F50C0", Offset = "0x26F44C0", Length = "0xC4")]
	[Token(Token = "0x6000281")]
	public bool IsChanged() { }

	[Address(RVA = "0x26F5190", Offset = "0x26F4590", Length = "0xE5")]
	[Token(Token = "0x6000286")]
	public bool IsNewPipiruLevel() { }

	[Address(RVA = "0x26F5280", Offset = "0x26F4680", Length = "0x128")]
	[Token(Token = "0x600028C")]
	public bool IsPipiruComicUnlockable(long pipirus) { }

	[Address(RVA = "0x26F53B0", Offset = "0x26F47B0", Length = "0x100")]
	[Token(Token = "0x6000282")]
	public bool Load() { }

	[Address(RVA = "0x26F54C0", Offset = "0x26F48C0", Length = "0xE3")]
	[Token(Token = "0x600028D")]
	public int MaxShotLevel() { }

	[Address(RVA = "0x26F55B0", Offset = "0x26F49B0", Length = "0x72")]
	[Token(Token = "0x6000289")]
	public int PipiruLevelNow() { }

	[Address(RVA = "0x26F5630", Offset = "0x26F4A30", Length = "0x6B")]
	[Token(Token = "0x600028A")]
	public int PipirusLevelPrevViewed() { }

	[Address(RVA = "0x26F56A0", Offset = "0x26F4AA0", Length = "0x1D")]
	[Token(Token = "0x6000285")]
	public long PlayerLevel() { }

	[Address(RVA = "0x26F56C0", Offset = "0x26F4AC0", Length = "0x84")]
	[Token(Token = "0x600027F")]
	public void RollBack() { }

	[Address(RVA = "0x26F5750", Offset = "0x26F4B50", Length = "0xC4")]
	[Token(Token = "0x6000283")]
	public void Save(bool forceFlg = false) { }

	[Address(RVA = "0x26F5820", Offset = "0x26F4C20", Length = "0xDA")]
	[Token(Token = "0x6000287")]
	public void SetViewedPipiruLevel() { }

	[Address(RVA = "0x26F5900", Offset = "0x26F4D00", Length = "0x6B")]
	[Token(Token = "0x6000288")]
	public long TotalPipirusCount() { }

	[Address(RVA = "0x26F5970", Offset = "0x26F4D70", Length = "0x27F")]
	[Token(Token = "0x600027E")]
	public void Update(in UpdateParam param) { }

}

