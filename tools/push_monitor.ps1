# Simple upload monitor for the git/LFS push. Run: powershell -File tools\push_monitor.ps1 [-TotalMB 7567] [-Interval 10] [-Once]
# Counts bytes git-lfs has read from disk (what it uploads) since this monitor started and shows speed and ETA.
param([double]$TotalMB = 7567, [int]$Interval = 10, [switch]$Once)

$done = 0.0; $lastPid = 0; $lastRead = 0.0; $start = Get-Date; $recent = New-Object System.Collections.Generic.Queue[object]
while ($true) {
    $p = Get-Process git-lfs -ErrorAction SilentlyContinue | Select-Object -First 1
    $state = 'idle (no git-lfs running)'
    if ($p) {
        $read = (Get-CimInstance Win32_Process -Filter "ProcessId=$($p.Id)").ReadTransferCount / 1MB
        if ($p.Id -eq $lastPid) { $done += [Math]::Max(0, $read - $lastRead) } else { $done += 0 }
        $lastPid = $p.Id; $lastRead = $read; $state = "uploading (git-lfs pid $($p.Id))"
    } else { $lastPid = 0 }
    $now = Get-Date
    $recent.Enqueue([pscustomobject]@{ T = $now; D = $done })
    while ($recent.Count -gt 1 -and ($now - $recent.Peek().T).TotalSeconds -gt 120) { [void]$recent.Dequeue() }
    $first = $recent.Peek()
    $span = ($now - $first.T).TotalSeconds
    $speed = if ($span -gt 0) { ($done - $first.D) / $span } else { 0 }
    $left = [Math]::Max(0, $TotalMB - $done)
    $eta = if ($speed -gt 0.01) { [TimeSpan]::FromSeconds($left / $speed).ToString('hh\:mm\:ss') } else { '--:--:--' }
    $pct = [Math]::Min(100, 100 * $done / $TotalMB)
    $bar = ('#' * [int]($pct / 2.5)).PadRight(40, '.')
    $line = "{0:HH:mm:ss} [{1}] {2,5:N1}%  {3,7:N0}/{4:N0} MB  {5,5:N2} MB/s  ETA {6}  {7}" -f $now, $bar, $pct, $done, $TotalMB, $speed, $eta, $state
    Write-Host $line
    if ($Once) { break }
    Start-Sleep $Interval
}
