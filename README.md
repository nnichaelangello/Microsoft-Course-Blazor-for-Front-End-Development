# EventEase Blazor Project

## Project Overview
EventEase is a Blazor web application designed to manage and display events with features for user registration and attendance tracking. This project was developed as part of the Microsoft Course on Blazor for Front-End Development, using Microsoft Copilot to assist with code generation, debugging, and optimization.

## Project Structure
```
Components/
  EventCard.razor         # Component for displaying event cards
Models/
  Event.cs                # Data model for events
Pages/
  EventDetails.razor      # Page for detailed event view
  EventList.razor         # Page displaying list of events
  Register.razor          # Registration page with form validation
Services/
  EventService.cs         # Service for event data management
wwwroot/css/
  site.css                # Custom styles
Program.cs                # Application startup configuration
```

## Features
- **Event Management**: Display and navigate between events
- **Two-way Data Binding**: Implemented in EventCard component
- **Routing**: Navigation between event list and details pages
- **Form Validation**: Registration form with input validation
- **Performance Optimization**: Addressed routing and rendering issues

## How Copilot Assisted
1. **Component Generation**: Copilot helped generate the foundational EventCard component with proper data binding
2. **Debugging**: Assisted in identifying and fixing routing errors and component lifecycle issues
3. **Optimization**: Suggested performance improvements for event rendering
4. **Advanced Features**: Guided implementation of form validation and state management
5. **Best Practices**: Provided recommendations for Blazor project structure and patterns

## Setup Instructions
1. Clone the repository: `git clone https://github.com/nnichaelangello/Microsoft-Course-Blazor-for-Front-End-Development.git`
2. Ensure you have .NET SDK installed (version 6.0 or higher recommended)
3. Navigate to project directory
4. Run `dotnet run` to start the application
5. Access the application at `https://localhost:5001`

## Course Context
This project was developed as part of the Microsoft Course on Blazor for Front-End Development, demonstrating practical implementation of Blazor components, routing, and state management.
