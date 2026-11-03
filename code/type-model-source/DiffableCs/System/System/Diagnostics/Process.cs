namespace System.Diagnostics;

[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
[Token(Token = "0x2000107")]
public class Process : Component
{
	[Token(Token = "0x2000109")]
	private enum State : int
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12,
	}

	[Token(Token = "0x2000108")]
	private enum StreamReadMode : int
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000491")]
	private bool haveProcessId; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000492")]
	private int processId; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000493")]
	private bool haveProcessHandle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000494")]
	private SafeProcessHandle m_processHandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000495")]
	private bool isRemoteMachine; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000496")]
	private string machineName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000497")]
	private int m_processAccess; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000498")]
	private ProcessThreadCollection threads; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000499")]
	private ProcessModuleCollection modules; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400049A")]
	private bool haveWorkingSetLimits; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400049B")]
	private bool havePriorityClass; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x400049C")]
	private bool watchForExit; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x400049D")]
	private bool watchingForExit; //Field offset: 0x6B
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400049E")]
	private EventHandler onExited; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400049F")]
	private bool exited; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40004A0")]
	private int exitCode; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004A1")]
	private bool signaled; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x40004A2")]
	private bool haveExitTime; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x40004A3")]
	private bool raisedOnExited; //Field offset: 0x82
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004A4")]
	private RegisteredWaitHandle registeredWaitHandle; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40004A5")]
	private WaitHandle waitHandle; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40004A6")]
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40004A7")]
	private StreamReader standardOutput; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40004A8")]
	private StreamWriter standardInput; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40004A9")]
	private StreamReader standardError; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40004AA")]
	private bool disposed; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40004AB")]
	private StreamReadMode outputStreamReadMode; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40004AC")]
	private StreamReadMode errorStreamReadMode; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40004AD")]
	private StreamReadMode inputStreamReadMode; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40004AE")]
	internal AsyncStreamReader output; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40004AF")]
	internal AsyncStreamReader error; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40004B0")]
	private string process_name; //Field offset: 0xD8

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	[Token(Token = "0x17000101")]
	private bool Associated
	{
		[Address(RVA = "0x2630A40", Offset = "0x262FE40", Length = "0xD")]
		[Token(Token = "0x600065F")]
		private get { } //Length: 13
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	[Token(Token = "0x17000102")]
	public bool HasExited
	{
		[Address(RVA = "0x2630A50", Offset = "0x262FE50", Length = "0x345")]
		[Token(Token = "0x6000660")]
		 get { } //Length: 837
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The unique identifier for the process.")]
	[Token(Token = "0x17000103")]
	public int Id
	{
		[Address(RVA = "0x2630DA0", Offset = "0x26301A0", Length = "0x1F")]
		[Token(Token = "0x6000661")]
		 get { } //Length: 31
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The name of this process.")]
	[Token(Token = "0x17000105")]
	public string ProcessName
	{
		[Address(RVA = "0x2630DC0", Offset = "0x26301C0", Length = "0x24E")]
		[Token(Token = "0x6000670")]
		 get { } //Length: 590
	}

	[Browsable(False)]
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	[Token(Token = "0x17000104")]
	public ISynchronizeInvoke SynchronizingObject
	{
		[Address(RVA = "0x2631010", Offset = "0x2630410", Length = "0x176")]
		[Token(Token = "0x6000662")]
		 get { } //Length: 374
	}

	[Address(RVA = "0x26309A0", Offset = "0x262FDA0", Length = "0x9C")]
	[Token(Token = "0x600065E")]
	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	[Address(RVA = "0x262FA10", Offset = "0x262EE10", Length = "0x229")]
	[Token(Token = "0x6000665")]
	public void Close() { }

	[Address(RVA = "0x262FC40", Offset = "0x262F040", Length = "0x45")]
	[Token(Token = "0x6000664")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x262FC90", Offset = "0x262F090", Length = "0x27E")]
	[Token(Token = "0x6000666")]
	private void EnsureState(State state) { }

	[Address(RVA = "0x2630A40", Offset = "0x262FE40", Length = "0xD")]
	[Token(Token = "0x600065F")]
	private bool get_Associated() { }

	[Address(RVA = "0x2630A50", Offset = "0x262FE50", Length = "0x345")]
	[Token(Token = "0x6000660")]
	public bool get_HasExited() { }

	[Address(RVA = "0x2630DA0", Offset = "0x26301A0", Length = "0x1F")]
	[Token(Token = "0x6000661")]
	public int get_Id() { }

	[Address(RVA = "0x2630DC0", Offset = "0x26301C0", Length = "0x24E")]
	[Token(Token = "0x6000670")]
	public string get_ProcessName() { }

	[Address(RVA = "0x2631010", Offset = "0x2630410", Length = "0x176")]
	[Token(Token = "0x6000662")]
	public ISynchronizeInvoke get_SynchronizingObject() { }

	[Address(RVA = "0x262FF10", Offset = "0x262F310", Length = "0xCF")]
	[Token(Token = "0x6000667")]
	public static Process GetCurrentProcess() { }

	[Address(RVA = "0x262FFE0", Offset = "0x262F3E0", Length = "0x33E")]
	[Token(Token = "0x6000669")]
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	[Address(RVA = "0x2630320", Offset = "0x262F720", Length = "0xB")]
	[Token(Token = "0x600066A")]
	private SafeProcessHandle GetProcessHandle(int access) { }

	[Address(RVA = "0x2630330", Offset = "0x262F730", Length = "0x253")]
	[Token(Token = "0x6000668")]
	protected void OnExited() { }

	[Address(RVA = "0x2630590", Offset = "0x262F990", Length = "0x5")]
	[Token(Token = "0x600066E")]
	private static string ProcessName_icall(IntPtr handle) { }

	[Address(RVA = "0x26305A0", Offset = "0x262F9A0", Length = "0xC2")]
	[Token(Token = "0x600066F")]
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	[Address(RVA = "0x2630670", Offset = "0x262FA70", Length = "0xA7")]
	[Token(Token = "0x6000671")]
	private void RaiseOnExited() { }

	[Address(RVA = "0x2630720", Offset = "0x262FB20", Length = "0x48")]
	[Token(Token = "0x600066B")]
	public void Refresh() { }

	[Address(RVA = "0x2630770", Offset = "0x262FB70", Length = "0x1F")]
	[Token(Token = "0x6000663")]
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	[Address(RVA = "0x2630790", Offset = "0x262FB90", Length = "0x109")]
	[Token(Token = "0x600066C")]
	private void StopWatchingForExit() { }

	[Address(RVA = "0x26308A0", Offset = "0x262FCA0", Length = "0xFF")]
	[Token(Token = "0x600066D")]
	public virtual string ToString() { }

}

