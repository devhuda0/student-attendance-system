# Team Collaboration Record

Project: Student Attendance System · Platform: GitHub · Supervisor: Dr. Sirwan Abdulwaed Aula

## 1. Member responsibilities
| Member | Responsibility | Main folders |
| --- | --- | --- |
| Chro Khurshid Saleh | Requirements and documentation | docs/ |
| Huda Ali Saleh | Repository maintainer: settings, final merges, README | root, docs/collaboration/ |
| Zulaikha Sadaadin Ismaeel | Database design and SQLite scripts | src/ (data layer) |
| Hazha Hadi Kakhamad | Windows Forms user interface | src/ (UI) |
| Soz Aziz Mustafa | Test cases, testing and review checks | tests/ |

## 2. Branch and commit workflow
- `main` always holds reviewed material; nobody commits to it directly.
- Each task gets its own branch: `feature/<task>`, `docs/<task>` or `fix/<task>`.
- Run `git status` and `git diff` before staging; stage only the intended files.
- Commit small, focused changes with a message that explains the change (never "update").
- Push the branch and open a pull request stating the purpose, changes, tests and limitations.

## 3. Review rule
- Every pull request needs **at least one approval from a teammate** who is not its author.
- The reviewer checks the folder, the commit messages, the match with requirements FR1–FR7, and that no passwords, tokens or personal data are included; code is run or tested first.
- The repository maintainer merges after approval; the author then deletes the merged branch.

## 4. Conflict-handling plan
- Pull the latest `main` into your branch often so that conflicts stay small.
- When Git reports a conflict, inspect both changes; never choose one side blindly.
- Contact the other author, agree on the intended result against the requirements, then edit the file and remove the conflict markers.
- Test, stage and complete the merge. If no agreement is possible, the maintainer decides and the supervisor is consulted on requirement questions.
- Force-pushing shared branches is forbidden; an exposed secret is replaced immediately.
 Reviewed by: Chro Khurshid Saleh
Review method: pull request approved by a teammate
