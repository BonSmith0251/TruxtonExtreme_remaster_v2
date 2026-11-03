# Writes bos02-constants.json from values read in Ene_Bos02..cctor (0x1D812B0), metadata field-RVA data and literal fields.
import json, struct
mb = open(r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat', 'rb').read()
D = 0x7ed7c8  # fieldAndParameterDefaultValueData
patrol_order = list(struct.unpack_from('<11i', mb, D + 543544))   # field-RVA blob, fieldRef 28 -> <PrivateImplementationDetails>+18
under_dir = list(struct.unpack_from('<8f', mb, D + 543616))       # fieldRef 30 -> +20
pts = [[-70,0,50],[-35,0,50],[0,0,50],[35,0,50],[70,0,50],[-70,0,30],[-35,0,30],[0,0,30],[35,0,30],[70,0,30]]
t6 = [(0,0),(0,7),(1.5,1),(1.5,6),(3,2),(3,5),(4.5,3),(4.5,4),(8,1),(8,2),(8,5),(8,6),(9.5,0),(9.5,3),(9.5,4),(9.5,7)] + \
     [(12,b) for b in range(8)] + [(13.5,b) for b in range(8)] + [(15,b) for b in range(8)]
out = {
 'source': 'Ene_Bos02..cctor RVA 0x1D812B0 (statics), literal const fields from code/types.jsonl, field-RVA arrays from global-metadata.dat fieldAndParameterDefaultValueData',
 'statics': {
  '_coreRot_euler_deg': [180, 0, 0], '_modelTopRotateStart_euler_deg': [0, 180, 0],
  '_underLaserMuzzleDir_deg': under_dir, '_callLSide': [-100, 20, 0], '_callRSide': [100, 20, 0], 'lastHomePosition': [0, 0, 20],
  'btNames': ['Boss02/bos02laser01','Boss02/bos02laser10','Boss02/bos02way8','Boss02/bos02b04x3','Boss02/bos02way16_1','Boss02/bos02way16_2','Boss02/bos02way5','Boss02/bos02way6_1','Boss02/bos02way6_2'],
  '_boss02ClipDatas': ['bos02_00_sa01'], 'MuzzleCount': 3, '_EntryNoHitTime': 3.5,
  'PatrolPoints': pts, 'PatrolOrder': patrol_order,
  '_Pattern6TimeTable_time_battery': t6,
  '_Pattern7Table_battery_start_move': [[0,180,-25],[1,-90,-25],[2,0,-25],[3,-180,25],[4,90,25],[5,0,25]],
 },
 'literals': {'_coreMuzzleArc': -60, 'HorizontalLimitRange': 80, 'MoveSpeedMax': 20, 'MoveSpeedMin': 10, 'MoveAcceleration': 6, 'MoveDeceleration': 4,
  'PositionDeadZone': 1.5, 'PositionSpeedRange': 60, 'RollTargetScale': 1.5, 'RollResponse': 20, 'RollDamping': 3, 'MaxRollAngle': 4,
  'PatternAttackInitialDuration': 5, 'PatternAttackDurationDecrement': 1, 'PatternAttackMinimumDuration': 1, 'PatternAttackCooldown': 0.5,
  'Pattern1FireInterval': 0.2, 'Pattern2FireInterval': 0.1, 'Pattern3FireInterval': 0.05, 'PatrolStartIndex': 0, 'PatrolArrivalRadius': 5,
  'PatrolMoveSpeedMax': 20, 'PatrolMoveSpeedMin': 10, 'PatrolOrbitSpeedMax': 8, 'PatrolOrbitMinDuration': 3, 'PatrolAccelerationDuration': 3,
  'PatrolDecelerationDuration': 2, 'OrbitAlignmentThreshold': 0.95, 'PatrolDistanceEpsilon': 0.001, 'PatrolPostArrivalDelay': 5,
  'PatrolBackLine': 50, 'PatrolFrontLine': 30, 'Pattern5StartDelay': 0, 'Pattern5PostFireDelay': 5, 'Pattern5Interval': 0,
  'Pattern6StartDelay': 5, 'Pattern6Interval': 10, 'Pattern7StartDelay': 1, 'Pattern7Interval': 10, 'Pattern7FireInterval': 0.1,
  'Pattern7FireInitial': 2, 'Pattern7FireMiddle': 2, 'Pattern7FireFinal': 1, 'Pattern7RollRange': 25},
 'base': {'Ene_BosBase.hpRateRanges': [0.9, 0.75, 0.51, 0.4, 0.3, 0.2, 0.1, 0.0], 'UIBossGauge.defaultBossTimeMax(GetBattileTime)': 180.0,
  'actStepSeconds': 10, 'TimeSteps.Passed90': 9, 'HitPState.LowHP': 4},
 'muzzles': {'Boss02MZ': ['muzzle_body_front_laser', 'muzzle_body_front_core', 'muzzle_body_core'],
  'pack.undercore': ['wing_under06/wing02_battery/wing02_battery_core','wing_under06/wing02_battery (1)/wing02_battery_core','wing_under06/wing02_battery (2)/wing02_battery_core',
                     'wing_under04/wing02_battery (3)/wing02_battery_core','wing_under04/wing02_battery (4)/wing02_battery_core','wing_under04/wing02_battery (5)/wing02_battery_core'],
  'pack.underl': ['wing_under06/muzzle_wingunder06_laser04','wing_under06/muzzle_wingunder06_laser03','wing_under06/muzzle_wingunder06_laser02','wing_under06/muzzle_wingunder06_laser01',
                  'wing_under04/muzzle_wingunder04_laser01','wing_under04/muzzle_wingunder04_laser02','wing_under04/muzzle_wingunder04_laser03','wing_under04/muzzle_wingunder04_laser04'],
  'pack.upperl': ['wing_upper04/muzzle_wingupper04_01','wing_upper04/muzzle_winguppre04_02','wing_upper06/muzzle_wingupper06_01','wing_upper06/muzzle_wingupper06_02'],
  '_backCores': ['wing_under06/wing02_battery (2)/wing02_battery_core','wing_under04/wing02_battery (5)/wing02_battery_core','wing_under06/wing02_battery (1)/wing02_battery_core',
                 'wing_under04/wing02_battery (4)/wing02_battery_core','wing_under06/wing02_battery/wing02_battery_core','wing_under04/wing02_battery (3)/wing02_battery_core'],
  '_bodyFront': 'body_front', '_backWingL': 'wing_under06', '_backWingR': 'wing_under04', 'pathPrefix': 'Pf_Ene_Bos02/pf_bs02/'},
 'sounds': {'61': 'bg2_boss_app_01', '70': 'bg2_boss_mainwing_operating', '71': 'bg2_boss_cannon_move_01', '40': 'exp_st3_boss_a01', '42': 'exp_st3_boss_c03', '177': 'boss_defeat01_01', '41': 'exp_st3_boss_b02 (_overplayDeadSound)', '106': 'enemybullet013_01 (ChangeSE B004 for all boss templates)'},
}
json.dump(out, open('bos02-constants.json', 'w'), indent=1)
print(patrol_order, under_dir)
