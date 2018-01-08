import pywinauto
from pywinauto.application import Application


# change the app path here:
EXEPATH = r'E:\Projects\Simple\Students\RegExTester\RegExTester\bin\Release\RegExTester.exe'

# Run a target application
app = Application(backend="uia").start(EXEPATH)

app['RegExTester'].print_control_identifiers()

app.kill()


# OUTPUT: 
# Control Identifiers:
# b'\nDialog - \'RegExTester\'    (L128, T128, R965, B688)\n[\'RegExTester\', \'Dialog\', \'RegExTesterDialog\']\nchild_window(title="RegExTester", auto_id="RegExTesterForm", control_type="Window")'
# b'   | \n   | Static - \'Test String:\'    (L154, T271, R296, B294)\n   | [\'Test String:Static\', \'Static0\', \'Static\', \'Test String:\', \'Static1\']\n   | child_window(title="Test String:", auto_id="label2", control_type="Text")'
# b'   | \n   | Static - \'Regular Expression:\'    (L154, T182, R373, B205)\n   | [\'Static2\', \'Regular Expression:Static\', \'Regular Expression:\']\n   | child_window(title="Regular Expression:", auto_id="label1", control_type="Text")'
# b'   | \n   | Button - \'Go!\'    (L153, T363, R933, B418)\n   | [\'Go!Button\', \'Button1\', \'Go!\', \'Button\', \'Button0\']\n   | child_window(title="Go!", auto_id="buttonGo", control_type="Button")'
# b'   | \n   | Edit - \'\'    (L153, T298, R932, B336)\n   | [\'\', \'Edit\', \'Edit1\', \'Edit0\', \'0\', \'1\']\n   | child_window(auto_id="textBoxTestString", control_type="Edit")'
# b'   | \n   | Edit - \'\'    (L154, T214, R933, B252)\n   | [\'2\', \'Edit2\']\n   | child_window(auto_id="textBoxRegEx", control_type="Edit")'
# b'   | \n   | ListBox - \'\'    (L154, T442, R933, B632)\n   | [\'ListBox\', \'3\']\n   | child_window(auto_id="listBoxResults", control_type="List")'
# b"   | \n   | TitleBar - 'None'    (L157, T131, R956, B166)\n   | ['4', 'TitleBar']\n"
# b'   |    | \n   |    | Menu - \'\xd1\xe8\xf1\xf2\xe5\xec\xe0\'    (L137, T137, R165, B165)\n   |    | [\'\xd1\xe8\xf1\xf2\xe5\xec\xe0\', \'\xd1\xe8\xf1\xf2\xe5\xec\xe01\', \'\xd1\xe8\xf1\xf2\xe5\xec\xe0Menu\', \'\xd1\xe8\xf1\xf2\xe5\xec\xe00\', \'Menu\']\n   |    | child_window(title="\xd1\xe8\xf1\xf2\xe5\xec\xe0", auto_id="MenuBar", control_type="MenuBar")'
# b'   |    |    | \n   |    |    | MenuItem - \'\xd1\xe8\xf1\xf2\xe5\xec\xe0\'    (L137, T137, R165, B165)\n   |    |    | [\'\xd1\xe8\xf1\xf2\xe5\xec\xe0MenuItem\', \'\xd1\xe8\xf1\xf2\xe5\xec\xe02\', \'MenuItem\']\n   |    |    | child_window(title="\xd1\xe8\xf1\xf2\xe5\xec\xe0", control_type="MenuItem")'
# b'   |    | \n   |    | Button - \'\xd1\xe2\xe5\xf0\xed\xf3\xf2\xfc\'    (L778, T129, R838, B166)\n   |    | [\'Button2\', \'\xd1\xe2\xe5\xf0\xed\xf3\xf2\xfc\', \'\xd1\xe2\xe5\xf0\xed\xf3\xf2\xfcButton\']\n   |    | child_window(title="\xd1\xe2\xe5\xf0\xed\xf3\xf2\xfc", control_type="Button")'
# b'   |    | \n   |    | Button - \'\xd0\xe0\xe7\xe2\xe5\xf0\xed\xf3\xf2\xfc\'    (L838, T129, R897, B166)\n   |    | [\'\xd0\xe0\xe7\xe2\xe5\xf0\xed\xf3\xf2\xfcButton\', \'\xd0\xe0\xe7\xe2\xe5\xf0\xed\xf3\xf2\xfc\', \'Button3\']\n   |    | child_window(title="\xd0\xe0\xe7\xe2\xe5\xf0\xed\xf3\xf2\xfc", control_type="Button")'
# b'   |    | \n   |    | Button - \'\xc7\xe0\xea\xf0\xfb\xf2\xfc\'    (L897, T129, R957, B166)\n   |    | [\'\xc7\xe0\xea\xf0\xfb\xf2\xfcButton\', \'\xc7\xe0\xea\xf0\xfb\xf2\xfc\', \'Button4\']\n   |    | child_window(title="\xc7\xe0\xea\xf0\xfb\xf2\xfc", control_type="Button")'
