# 🚨 National Emergency Alert System

This is a simple console-based C# project that simulates a national emergency alert system. It displays emergency alert levels, descriptions, and city-wide response instructions.

---

## 📖 Description

The National Emergency Alert System is part of my C# learning journey. It demonstrates the use of:

- `enum` to define different alert levels
- `switch` statements to customize messages
- Arrays to list affected cities
- Loops and conditional logic for output control
- Console output formatting for readability

---

## 💡 Alert Levels

The system defines three alert levels using an `enum`:

| Level     | Value | Description                         |
|-----------|-------|-------------------------------------|
| CodeRed   | 0     | 🔥 Fire or explosion risk           |
| CodeBlue  | 1     | 🩺 Medical or severe weather alert  |
| CodeYellow| 2     | ⚠️ General caution/system alert     |

Each level prints:
- The alert name and numeric value
- A custom warning message
- Instructions for a list of cities

---

## 🏙️ Affected Cities

The system automatically lists predefined cities (e.g., Lagos, Abuja, Kano, Port Harcourt) and the corresponding safety instructions for each alert level.

---

## 🧪 Sample Output

