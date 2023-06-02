
# RocketGame (course project2)



## Game Screen

- rocket fly from point A to point B
- one button for moving forward, left and right button for controlling rotation
- moving obsticles for challenge and increase fun of the Game
 



## Notes
    1. 'input' class from unity api allowing user to give input from keyboard
    2. 'rigid body' compoent supported by unity API gives physical property of the object
     
## ShortCut in unity
    1. alt+left/right click => expand or collapse
    2. 'time.deltatime' can give delta time between two frame, cuz they may vary between computers,
    3. whatever changed on the instance of object can be used to overwrite the object in the prefab
    4. 'other.gameobject.tag' is used to access the value of tag
    5. without specify public or protected, it's assumed to be private
    6. SceneManager is used to access and control loading scenes in the buildsettings  
    7. 'invoke(certain_method, delaySeconds)' method allow to call and execute certain method after amount of delaySeconds