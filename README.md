# Instance Controller
A tool that allows you to prevent applications from being launched multiple times, or just for logging executions of the selected application.

# How to Use
1. Place "IC.exe" in a location of your choice.
2. Open "IC.exe", this is where you will configure IC and how it behaves.
3. Select the elipses to browse to an executable.   
4. Select the executable you wish to limit. 
5. Tick "Allow Only One Instance".
6. Click "Apply".
7. Click "Yes".
8. Opening "IC.exe" will now open the application you selected in step a2, it will now display a message when trying to open more than 1 instance.
       
# "View More Options"

Clicking on this button will present you with more options you can use once you have selected a file.

**"Limit to X instances"** - This allows you to configure a custom number of instances for the selected application.
   
**"Prompt Override"** - This will present the user with a choice as to whether they wish to proceed past the instance limit previously set.
    
**"Display Message (before app launch)"** - This allows you to define a message to show the user before the application is opened.
    
**"Log Execution"** - This option will create a new file called "<selected app name>.log" and will log the execution of the program in the following format
    
    [DATE] [TIME] | Process: [Process Name] | User: [PC Name]\[Username] | Status: ['Opened', 'Opened with override']
        
**"Launch with arguments"** - You can define a list of arguments that you wish to open the application with.
   
    
