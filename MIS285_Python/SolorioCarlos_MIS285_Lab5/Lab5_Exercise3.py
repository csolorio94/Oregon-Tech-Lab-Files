import win32evtlog
import os

server = 'localhost'
logtype = 'Security' # 'Application' # 'Security'
hand = win32evtlog.OpenEventLog(server,logtype)
flags = win32evtlog.EVENTLOG_BACKWARDS_READ|win32evtlog.EVENTLOG_SEQUENTIAL_READ
total = win32evtlog.GetNumberOfEventLogRecords(hand)
print('Login Attempts: ', file = open('login_file.txt', 'a'))
while True:
    events = win32evtlog.ReadEventLog(hand, flags,0)
    if events:
        for event in events:
            if event.EventID == 4624:
                date = str(event.TimeGenerated)
                print(date, file = open('login_file.txt', 'a'))