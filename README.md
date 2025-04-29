# 📨 Message Queue Producer-Consumer Application

## ✅ Assignment Overview

This project is built as part of an evaluation for the .NET Developer profile.

### 📝 Task Description

> Develop a simple message-driven application in .NET (C#) that simulates a **producer-consumer** scenario using a **message queue**.

### 📋 Requirements:
- Simulate producer and consumer communication via a message queue.
- Track and log:
  - ✅ Total number of messages **successfully processed**.
  - ❌ Number of **errors** encountered.
- Include **unit test cases** for both success and failure scenarios.
- Ensure code is:
  - ✅ Well-documented
  - 📘 Easy to understand
  - 🧪 Testable
  - 🛠️ Easy to run

---

## 📂 Project Structure
MessageQueueApp/ │ ├── Program.cs # Entry point ├── Models/ │ └── Message.cs # Basic message object ├── Queue/ │ └── MessageQueue.cs # Queue for producer-consumer ├── Producer/ │ └── Producer.cs # Adds messages to queue ├── Consumer/ │ └── Consumer.cs # Processes messages ├── Stats/ │ └── MessageStats.cs # Tracks success/failure counts ├── Logging/ │ └── LoggingService.cs # Logs info and error messages ├── Tests/ │ └── ConsumerTests.cs # Unit tests using xUnit └── README.md 

---

## ⚙️ How to Run

### 🔧 Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) 6 or later installed

### ▶️ Run the Application
dotnet run

## 🧪 Run Unit Tests
dotnet test

## 🚀 Features

Feature	Description
📨 Producer	Generates messages (some meant to fail)
📥 Queue	Stores messages to be processed
⚙️ Consumer	Processes each message
📊 Stats	Tracks success and failure counts
📓 LoggingService	Logs message status (success/error)
🧪 Unit Testing	Validates correct handling of all scenarios

## 👤 Author
Suraj Kumar
.NET Developer – Assignment Submission
