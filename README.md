# Student Attendance System

**Soran University – Faculty of Science – Computer Science Department**
Software Engineering (SOU30542) – Group Project, 2026–2027
Supervisor: Dr. Sirwan Abdulwaed Aula

## About the project
A desktop application that replaces paper attendance rosters. Instructors record attendance for each lecture, and admins manage accounts, courses and reports. The system also calculates absence percentages automatically and warns about students with too many absences.

## Technologies
- C# Windows Forms (.NET)
- SQLite database
- Git and GitHub for version control

## Team and responsibilities
| Member | Main responsibility |
| --- | --- |
| Chro Khurshid Saleh | Requirements and documentation |
| Huda Ali Saleh | Repository maintainer: settings, final merges, README |
| Zulaikha Sadaadin Ismaeel | Database design and SQLite scripts |
| Hazha Hadi Kakhamad | Windows Forms user interface |
| Soz Aziz Mustafa | Test cases, testing and review checks |

## Project status
- Parts 1–3 (proposal, requirements, system modeling and design): completed
- Part 4 (Git and GitHub milestone): in progress
- Implementation and testing: planned

## Repository structure
```
student-attendance-system/
├── README.md
├── .gitignore
├── docs/
│   ├── proposal/        Part 1 project proposal
│   ├── design/          Part 3 design report and diagrams
│   └── collaboration/   Team collaboration record
├── src/                 C# Windows Forms source code (next phase)
└── tests/               Test cases and test code (next phase)
```

## Contribution rules (summary)
- `main` holds reviewed work only; nobody commits to it directly.
- Every task gets its own branch (`feature/<task>`, `docs/<task>` or `fix/<task>`).
- Commit messages must explain the change (never just "update").
- Every pull request needs at least one approval from a teammate.
- Never commit passwords, tokens, keys, databases or personal data.

Full details: [Team collaboration record](docs/collaboration/TEAM_COLLABORATION.md)
