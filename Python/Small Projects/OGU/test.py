''' OGU AUTOBUMPER PROTOTYPE version 0.1 
may code a fully featured and cross-platform
(run on any device or in the cloud!)
version, although this is functional...
just a req l00p'''

thread_ID_2bump = '792726' # thread id to bump

ogusersmybbuser = '255461_ZNUk6y7qJgA2eQSWAQ04Ed8Dsh1GeSuJst6YBAKdSvDIkglEX5' # your auth cookie

'''todo: automatically obtain ^
(along with other input variables, other than
thread url to bump, in non-prototype version)
'''

data = {
'subject': '',
'action': 'do_newreply',
'posthash': '',
'quoted_ids': '',
'lastpid': '',
'from_page': '1',
'tid': thread_ID_2bump, 
'method': 'quickreply',
'message': 'Bumping this thrad...',
'postoptions[signature]': '1' # toggle sig
}

from requests import post
from time import sleep

while True:
    bump = post('https://ogusers.com/newreply.php', cookies={'ogusersmybbuser': ogusersmybbuser}, data=data)
    if ('IM_UNDER_ATTACK_BOX' in bump.text):
        print('^ bump failed!')
        print('^^ captcha detected, evasion unsupported in prototype.')
    else:
        print('^ successfully bumped!')
    sleep(3600)