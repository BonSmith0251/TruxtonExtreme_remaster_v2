namespace Unity.Cinemachine.TargetTracking;

[Token(Token = "0x2000193")]
public enum BindingMode : int
{
	LockToTargetOnAssign = 0,
	LockToTargetWithWorldUp = 1,
	LockToTargetNoRoll = 2,
	LockToTarget = 3,
	WorldSpace = 4,
	LazyFollow = 5,
}

