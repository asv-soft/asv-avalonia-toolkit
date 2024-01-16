<div>
<img src="https://github.com/asv-soft/asv-drones-gui-afis/assets/151620493/932425b6-547e-4d35-bf90-6430265c8e97" width="300px" margin-left="200px">  
</div>

# Introduction asv-avalonia-toolkit
A set of advanced controls for Avalonia UI, used in the Asv.Drones application

# How to use

## Where can i get controls?
Controls avaliable to use in Asv.drones solution. Using this, you can customize UI by your need's. 
You can see implementation example on asv asv-avalonia-toolkit-gallery pages. 

## Binding
All contols have propetries that set value to different elements of controls such as progress bar, text, title, status(critical,succes,warning,unknown), etc...
Controls can be binded from View, direct to ViewModel current fields that's sets values to controll that you change. 
Example like this:

### ViewModel
```bash
public double ProgressValue { get; set; } /// we don't change exist property  
....
```
### View
```bash
<toolkit:circular3indicator
TopProgress="{Binding ProgressValue}"/> /// we set exist property to new control
...
```

# Avaliable controls:
Images of controls realized in asv-avalonia-toolkit.
## Circular indicator
![image](https://github.com/asv-soft/asv-avalonia-toolkit/assets/1770739/8e75af96-91e9-4d04-a533-099b369f4a72)

## Recording indicator

![image](https://github.com/asv-soft/asv-avalonia-toolkit/assets/1770739/09b4a06a-ac62-4192-aed2-9c1c4a5e2025)

## Route indicator

![image](https://github.com/asv-soft/asv-avalonia-toolkit/assets/1770739/eca3290c-e50a-426d-ae91-e0143d895c75)

