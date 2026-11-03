namespace UnityEngine.VFX.Utility;

[DefaultExecutionOrder(1)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(VisualEffect))]
[Token(Token = "0x2000067")]
public class VFXPropertyBinder : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000068")]
	private sealed class <GetPropertyBinders>d__17 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FF")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000200")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000201")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000202")]
		public VFXPropertyBinder <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000203")]
		private Enumerator<VFXBinderBase> <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x1700003D")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001FE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700003E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000200")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60001FA")]
		public <GetPropertyBinders>d__17`1(int <>1__state) { }

		[Address(RVA = "0x18090A0", Offset = "0x18084A0", Length = "0x41")]
		[Token(Token = "0x60001FD")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1808D80", Offset = "0x1808180", Length = "0x272")]
		[Token(Token = "0x60001FC")]
		private override bool MoveNext() { }

		[Address(RVA = "0xA66280", Offset = "0xA65680", Length = "0xAC")]
		[DebuggerHidden]
		[Token(Token = "0x6000201")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001FE")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x1154DC0", Offset = "0x11541C0", Length = "0xB8")]
		[DebuggerHidden]
		[Token(Token = "0x6000202")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000200")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60001FF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1809000", Offset = "0x1808400", Length = "0x92")]
		[DebuggerHidden]
		[Token(Token = "0x60001FB")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001FC")]
	protected bool m_ExecuteInEditor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FD")]
	public List<VFXBinderBase> m_Bindings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001FE")]
	protected VisualEffect m_VisualEffect; //Field offset: 0x30

	[Address(RVA = "0x2F7F420", Offset = "0x2F7E820", Length = "0x7B")]
	[Token(Token = "0x60001F9")]
	public VFXPropertyBinder() { }

	[Address(RVA = "0x9E3CE0", Offset = "0x9E30E0", Length = "0x67")]
	[Obsolete("Use AddPropertyBinder<T>() instead")]
	[Token(Token = "0x60001F0")]
	public T AddParameterBinder() { }

	[Address(RVA = "0x9E3D50", Offset = "0x9E3150", Length = "0x51")]
	[Token(Token = "0x60001EF")]
	public T AddPropertyBinder() { }

	[Address(RVA = "0x2F7EF10", Offset = "0x2F7E310", Length = "0x7")]
	[Obsolete("Please use ClearPropertyBinders() instead")]
	[Token(Token = "0x60001F2")]
	public void ClearParameterBinders() { }

	[Address(RVA = "0x2F7EF20", Offset = "0x2F7E320", Length = "0xC4")]
	[Token(Token = "0x60001F1")]
	public void ClearPropertyBinders() { }

	[Address(RVA = "0x9E3DB0", Offset = "0x9E31B0", Length = "0x9F")]
	[Obsolete("Please use GetPropertyBinders<T>() instead")]
	[Token(Token = "0x60001F8")]
	public IEnumerable<T> GetParameterBinders() { }

	[Address(RVA = "0x84D610", Offset = "0x84CA10", Length = "0x89")]
	[IteratorStateMachine(typeof(<GetPropertyBinders>d__17`1))]
	[Token(Token = "0x60001F7")]
	public IEnumerable<T> GetPropertyBinders() { }

	[Address(RVA = "0x2F7EFF0", Offset = "0x2F7E3F0", Length = "0x1EF")]
	[Token(Token = "0x60001EE")]
	private void LateUpdate() { }

	[Address(RVA = "0x2F7F1E0", Offset = "0x2F7E5E0", Length = "0x7")]
	[Token(Token = "0x60001E9")]
	private void OnEnable() { }

	[Address(RVA = "0x2F7F1E0", Offset = "0x2F7E5E0", Length = "0x7")]
	[Token(Token = "0x60001EA")]
	private void OnValidate() { }

	[Address(RVA = "0x2F7F1F0", Offset = "0x2F7E5F0", Length = "0xEE")]
	[Token(Token = "0x60001EC")]
	private void Reload() { }

	[Address(RVA = "0x2F7F2E0", Offset = "0x2F7E6E0", Length = "0xCB")]
	[Obsolete("Please use RemovePropertyBinder() instead")]
	[Token(Token = "0x60001F4")]
	public void RemoveParameterBinder(VFXBinderBase binder) { }

	[Address(RVA = "0x9E3E50", Offset = "0x9E3250", Length = "0xEF")]
	[Obsolete("Please use RemovePropertyBinders<T>() instead")]
	[Token(Token = "0x60001F6")]
	public void RemoveParameterBinders() { }

	[Address(RVA = "0x2F7F2E0", Offset = "0x2F7E6E0", Length = "0xCB")]
	[Token(Token = "0x60001F3")]
	public void RemovePropertyBinder(VFXBinderBase binder) { }

	[Address(RVA = "0x9E3F40", Offset = "0x9E3340", Length = "0xDF")]
	[Token(Token = "0x60001F5")]
	public void RemovePropertyBinders() { }

	[Address(RVA = "0x2F7F3B0", Offset = "0x2F7E7B0", Length = "0x1F")]
	[Token(Token = "0x60001ED")]
	private void Reset() { }

	[Address(RVA = "0x2F7F3D0", Offset = "0x2F7E7D0", Length = "0x49")]
	[Token(Token = "0x60001EB")]
	private static void SafeDestroy(object toDelete) { }

}

