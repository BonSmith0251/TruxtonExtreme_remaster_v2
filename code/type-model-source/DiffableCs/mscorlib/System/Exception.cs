namespace System;

[ComVisible(True)]
[Token(Token = "0x200018D")]
public class Exception : ISerializable
{
	[Token(Token = "0x200018E")]
	public enum ExceptionMessageKind : int
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3,
	}

	[OptionalField]
	[Token(Token = "0x40005AB")]
	private static object s_EDILock; //Field offset: 0x0
	[Token(Token = "0x40005BC")]
	private const int _COMPlusExceptionCode = -532462766; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005AC")]
	private string _className; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005AD")]
	internal string _message; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005AE")]
	private IDictionary _data; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005AF")]
	private Exception _innerException; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B0")]
	private string _helpURL; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B1")]
	private object _stackTrace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005B2")]
	private string _stackTraceString; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005B3")]
	private string _remoteStackTraceString; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005B4")]
	private int _remoteStackIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005B5")]
	private object _dynamicMethods; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005B6")]
	internal int _HResult; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005B7")]
	private string _source; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x40005B8")]
	private SafeSerializationManager _safeSerializationManager; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005B9")]
	internal StackTrace[] captured_traces; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005BA")]
	private IntPtr[] native_trace_ips; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40005BB")]
	private int caught_in_unmanaged; //Field offset: 0x88

	[Token(Token = "0x17000121")]
	public override IDictionary Data
	{
		[Address(RVA = "0x2069AA0", Offset = "0x2068EA0", Length = "0x69")]
		[Token(Token = "0x6000E33")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000126")]
	public int HResult
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x6000E41")]
		 get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[Token(Token = "0x6000E42")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000122")]
	public override Exception InnerException
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000E35")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000120")]
	public override string Message
	{
		[Address(RVA = "0x2069B20", Offset = "0x2068F20", Length = "0x118")]
		[Token(Token = "0x6000E32")]
		 get { } //Length: 280
	}

	[Token(Token = "0x17000125")]
	public override string Source
	{
		[Address(RVA = "0x2069C40", Offset = "0x2069040", Length = "0x147")]
		[Token(Token = "0x6000E3A")]
		 get { } //Length: 327
	}

	[Token(Token = "0x17000124")]
	public override string StackTrace
	{
		[Address(RVA = "0x2069D90", Offset = "0x2069190", Length = "0x3F")]
		[Token(Token = "0x6000E37")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000123")]
	public override MethodBase TargetSite
	{
		[Address(RVA = "0x2069DD0", Offset = "0x20691D0", Length = "0xB9")]
		[Token(Token = "0x6000E36")]
		 get { } //Length: 185
	}

	[Address(RVA = "0x2069480", Offset = "0x2068880", Length = "0x73")]
	[Token(Token = "0x6000E47")]
	private static Exception() { }

	[Address(RVA = "0x2069500", Offset = "0x2068900", Length = "0x1F")]
	[Token(Token = "0x6000E2E")]
	public Exception() { }

	[Address(RVA = "0x2069A00", Offset = "0x2068E00", Length = "0x3B")]
	[Token(Token = "0x6000E2F")]
	public Exception(string message) { }

	[Address(RVA = "0x2069A40", Offset = "0x2068E40", Length = "0x58")]
	[Token(Token = "0x6000E30")]
	public Exception(string message, Exception innerException) { }

	[Address(RVA = "0x2069520", Offset = "0x2068920", Length = "0x4D3")]
	[Token(Token = "0x6000E31")]
	protected Exception(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20688C0", Offset = "0x2067CC0", Length = "0xEB")]
	[Token(Token = "0x6000E45")]
	internal Exception FixRemotingException() { }

	[Address(RVA = "0x2069AA0", Offset = "0x2068EA0", Length = "0x69")]
	[Token(Token = "0x6000E33")]
	public override IDictionary get_Data() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x6000E41")]
	public int get_HResult() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000E35")]
	public override Exception get_InnerException() { }

	[Address(RVA = "0x2069B20", Offset = "0x2068F20", Length = "0x118")]
	[Token(Token = "0x6000E32")]
	public override string get_Message() { }

	[Address(RVA = "0x2069C40", Offset = "0x2069040", Length = "0x147")]
	[Token(Token = "0x6000E3A")]
	public override string get_Source() { }

	[Address(RVA = "0x2069D90", Offset = "0x2069190", Length = "0x3F")]
	[Token(Token = "0x6000E37")]
	public override string get_StackTrace() { }

	[Address(RVA = "0x2069DD0", Offset = "0x20691D0", Length = "0xB9")]
	[Token(Token = "0x6000E36")]
	public override MethodBase get_TargetSite() { }

	[Address(RVA = "0x20689B0", Offset = "0x2067DB0", Length = "0x52")]
	[Token(Token = "0x6000E34")]
	private string GetClassName() { }

	[Address(RVA = "0x2068A10", Offset = "0x2067E10", Length = "0x8D")]
	[Token(Token = "0x6000E44")]
	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) { }

	[Address(RVA = "0x2068AA0", Offset = "0x2067EA0", Length = "0x47F")]
	[Token(Token = "0x6000E3D")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2068F20", Offset = "0x2068320", Length = "0x43")]
	[Token(Token = "0x6000E38")]
	private string GetStackTrace(bool needFileInfo) { }

	[Address(RVA = "0x2051E40", Offset = "0x2051240", Length = "0x7")]
	[Token(Token = "0x6000E43")]
	public override Type GetType() { }

	[Address(RVA = "0x2068F70", Offset = "0x2068370", Length = "0x92")]
	[Token(Token = "0x6000E2D")]
	private void Init() { }

	[Address(RVA = "0x2069010", Offset = "0x2068410", Length = "0x8B")]
	[OnDeserialized]
	[Token(Token = "0x6000E3E")]
	private void OnDeserialized(StreamingContext context) { }

	[Address(RVA = "0x20690A0", Offset = "0x20684A0", Length = "0x5")]
	[Token(Token = "0x6000E46")]
	internal static void ReportUnhandledException(Exception exception) { }

	[Address(RVA = "0x20690B0", Offset = "0x20684B0", Length = "0xD8")]
	[Token(Token = "0x6000E40")]
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[Token(Token = "0x6000E42")]
	protected void set_HResult(int value) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[Token(Token = "0x6000E39")]
	internal void SetErrorCode(int hr) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000E3F")]
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	[Address(RVA = "0x2069470", Offset = "0x2068870", Length = "0xF")]
	[Token(Token = "0x6000E3B")]
	public virtual string ToString() { }

	[Address(RVA = "0x20691A0", Offset = "0x20685A0", Length = "0x2C6")]
	[Token(Token = "0x6000E3C")]
	private string ToString(bool needFileLineInfo, bool needMessage) { }

}

