# TRACKMATE
#### Video Demo:  https://www.youtube.com/watch?v=WEgvcBbyYDI

## Description

The main purpose of this application is to serve as an all-in-one dashboard for personal productivity. It combines the functionalities of a traditional to-do list with a flexible quantity tracking system. Users can input tasks, assign deadlines, and mark items as complete, while also being able to define and update custom quantities like money saved or hours worked.

By combining these two tools into one streamlined application, users no longer need to rely on multiple apps or manual methods to stay on track. This application is particularly useful for students, freelancers, or anyone who benefits from clear visual tracking of their goals and responsibilities.

## Features

- **Task Management System**: Users can add new tasks, set deadlines, and mark tasks as complete. Each task entry includes options for a short description and due date.
- **Custom Quantity Tracker**: This feature allows users to define numerical quantities such as "Saved Money", "Books Read", or "Work Hours". The values can be incremented, decremented, or set manually.
- **Clean and Intuitive GUI**: The application interface was designed in Figma and implemented using Windows Forms in Visual Studio. It prioritizes ease of use and minimal distraction.
- **Performance-Oriented Design**: The use of C++ in conjunction with the .NET framework ensures that the application runs efficiently with quick startup and minimal resource usage.

## Technology Stack and Decisions

The project was developed in C# due to its strong support for Windows desktop applications and ease of development.

The graphical interface was prototyped in Figma before implementation. This allowed me to iterate on the layout and user experience design without writing code prematurely. Visual Studio was chosen as the development environment due to its seamless integration with Windows Forms and robust debugging tools.

### Considered Alternatives

Several other options were explored during the planning phase:

- **C# with Windows Forms**: Would have been easier to implement but slightly slower and less efficient.
- **Cross-platform frameworks like Qt or wxWidgets**: These were considered for broader compatibility but would have added unnecessary complexity given the project's focus on Windows.
- **Electron with JavaScript**: Ultimately not chosen due to its high resource consumption compared to native applications.

## How to Use

1. Open the application.
2. To add a new task, use the input field and optionally assign a deadline.
3. Use the quantity tracker section to define and update any numerical value you wish to track.
4. Mark tasks as complete or delete them when no longer needed.
5. Quantities can be updated at any time using dedicated increment, decrement, and manual input options.

Future updates may include data persistence using local file storage, deadline reminders, and simple analytics to visualize trends over time.

## Conclusion

This productivity app was developed with simplicity, speed, and clarity in mind. It combines essential features for goal tracking and task management into a lightweight, responsive application. Every design and development choice was made to ensure the user has a seamless experience that helps them stay organized and motivated. Whether you are managing multiple projects or just trying to save more money, this tool is designed to help you stay focused and in control.

