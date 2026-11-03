namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F5")]
public enum RouteEventType : int
{
	None = 0,
	Delay = 1,
	Rotate = 2,
	RotateT = 3,
	Scale = 4,
	LabelEvent = 5,
	Horming = 6,
	Direction = 7,
	Bullet = 8,
	Animation = 9,
	SetObjFlag = 10,
	ResetObjFlag = 11,
	ForwardMove = 12,
	Translate = 13,
	Speed = 14,
	SplineMove = 15,
	Easing = 16,
	CustomEvent = 17,
	GravityForwardMove = 18,
	LookAt = 19,
	Idle = 20,
	Parts = 21,
	TaskWait = 80,
	TaskClear = 81,
	TaskCancel = 82,
	BulletSelecter = 83,
	RotateR = 84,
	Goto = 100,
	Loop = 101,
	FinishDestroy = 1000,
	FinishWait = 1001,
}

