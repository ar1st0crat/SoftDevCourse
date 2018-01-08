import pywinauto
from pywinauto.application import Application


# change the app path here:
EXEPATH = r'E:\Projects\Simple\Students\RegExTester\RegExTester\bin\Release\RegExTester.exe'

# Run a target application
app = Application(backend="uia").start(EXEPATH)

edit1 = pywinauto.controls.win32_controls.EditWrapper(
    app['RegExTester']['Edit1'])

edit2 = pywinauto.controls.win32_controls.EditWrapper(
    app['RegExTester']['Edit2'])

ok_button = pywinauto.controls.win32_controls.ButtonWrapper(
    app['RegExTester']['Go!Button'])

edit1.SetText('user23 and user45')
edit2.SetText(r'user\d{2}')

ok_button.click()

list_box = pywinauto.controls.win32_controls.ListBoxWrapper(
    app['RegExTester']['ListBox'])


print(list_box.item_count() == 2)
print(list_box.item_texts()[0].index('user23') >= 0)
print(list_box.item_texts()[1].index('user45') >= 0)
