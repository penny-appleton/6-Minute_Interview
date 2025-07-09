# Phone Number Validator

A Java project for validating and formatting phone numbers, supporting both North American and international formats.

## Project Structure

This is a Maven-based Java project with the following structure:

```
├── src/
│   ├── main/
│   │   └── java/
│   │       └── com/
│   │           └── interview/
│   │               └── PhoneNumber.java
│   └── test/
│       └── java/
│           └── com/
│               └── interview/
│                   └── PhoneNumberTest.java
├── .vscode/
│   ├── settings.json
│   └── tasks.json
├── .gitignore
├── pom.xml
└── README.md
```

## Building and Running

### Prerequisites

- Java 11 or higher
- Maven 3.6 or higher

### Build Commands

```bash
# Compile the project
mvn compile

# Run tests
mvn test

# Package the project
mvn package

# Clean build artifacts
mvn clean
```

### VS Code Tasks

If using VS Code, you can use the following tasks (Ctrl+Shift+P → "Tasks: Run Task"):

- **compile**: Compile the source code
- **test**: Run all unit tests
- **package**: Create a JAR file
- **clean**: Clean build artifacts

## Testing

The project includes comprehensive unit tests using JUnit and Hamcrest matchers. Run tests with:

```bash
mvn test
```

## Development

This project is set up for development in VS Code with:

- Java language support
- Maven integration
- Automatic import organization
- Google Java style formatting
- Build tasks and problem matchers
