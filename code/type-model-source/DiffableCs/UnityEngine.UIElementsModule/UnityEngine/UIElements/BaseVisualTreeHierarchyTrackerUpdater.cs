namespace UnityEngine.UIElements;

[Token(Token = "0x200055E")]
internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x200055F")]
	private enum State : int
	{
		Waiting = 0,
		TrackingAddOrMove = 1,
		TrackingRemove = 2,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011C5")]
	private State m_State; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011C6")]
	private VisualElement m_CurrentChangeElement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011C7")]
	private VisualElement m_CurrentChangeParent; //Field offset: 0x38

	[Address(RVA = "0x32D6E50", Offset = "0x32D6250", Length = "0xE")]
	[Token(Token = "0x6002727")]
	protected BaseVisualTreeHierarchyTrackerUpdater() { }

	[Token(Token = "0x6002721")]
	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	[Address(RVA = "0x32D6960", Offset = "0x32D5D60", Length = "0x21B")]
	[Token(Token = "0x6002722")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32D6B80", Offset = "0x32D5F80", Length = "0xB6")]
	[Token(Token = "0x6002725")]
	private void ProcessAddOrMove(VisualElement ve) { }

	[Address(RVA = "0x32D6C40", Offset = "0x32D6040", Length = "0xA3")]
	[Token(Token = "0x6002724")]
	private void ProcessNewChange(VisualElement ve) { }

	[Address(RVA = "0x32D6CF0", Offset = "0x32D60F0", Length = "0x9E")]
	[Token(Token = "0x6002726")]
	private void ProcessRemove(VisualElement ve) { }

	[Address(RVA = "0x32D6D90", Offset = "0x32D6190", Length = "0xBC")]
	[Token(Token = "0x6002723")]
	public virtual void Update() { }

}

