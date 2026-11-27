-- =====================================================================
-- Student Attendance System - SQLite database schema
-- Task: Issue #3 "Create database schema.sql" (Owner: Zulaikha)
-- Source: ER diagram, Part 3 (Figure 5): 7 tables
-- Branch: feature/database-schema      Reviewer: Hazha
-- NOTE: attendance.db is NOT committed (it is in .gitignore).
--       Create it locally from this script.
-- =====================================================================

PRAGMA foreign_keys = ON;   -- SQLite ignores foreign keys unless this is set

-- ---------------------------------------------------------------------
-- 1. USERS: instructors and admins (FR1, FR7)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS USERS (
    user_id   INTEGER PRIMARY KEY AUTOINCREMENT,
    name      TEXT NOT NULL,
    username  TEXT NOT NULL UNIQUE,
    password  TEXT NOT NULL,   -- store a password HASH, never plain text
    role      TEXT NOT NULL CHECK (role IN ('Admin', 'Instructor'))
);

-- ---------------------------------------------------------------------
-- 2. COURSES: each course is taught by one instructor (FR2)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS COURSES (
    course_id      INTEGER PRIMARY KEY AUTOINCREMENT,
    course_name    TEXT NOT NULL,
    schedule       TEXT,                                   -- e.g. 'Sun 09:00-11:00'
    absence_limit  INTEGER NOT NULL DEFAULT 3 CHECK (absence_limit >= 0),  -- used by FR6 alerts
    instructor_id  INTEGER NOT NULL,
    FOREIGN KEY (instructor_id) REFERENCES USERS(user_id)
);

-- ---------------------------------------------------------------------
-- 3. STUDENTS (FR2)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS STUDENTS (
    student_id  INTEGER PRIMARY KEY AUTOINCREMENT,
    name        TEXT NOT NULL,
    email       TEXT UNIQUE
);

-- ---------------------------------------------------------------------
-- 4. ENROLLMENT: many students <-> many courses (FR2)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS ENROLLMENT (
    enroll_id   INTEGER PRIMARY KEY AUTOINCREMENT,
    student_id  INTEGER NOT NULL,
    course_id   INTEGER NOT NULL,
    FOREIGN KEY (student_id) REFERENCES STUDENTS(student_id) ON DELETE CASCADE,
    FOREIGN KEY (course_id)  REFERENCES COURSES(course_id)   ON DELETE CASCADE,
    UNIQUE (student_id, course_id)          -- a student joins a course only once
);

-- ---------------------------------------------------------------------
-- 5. LECTURES: each course has many lectures (FR3)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS LECTURES (
    lecture_id  INTEGER PRIMARY KEY AUTOINCREMENT,
    course_id   INTEGER NOT NULL,
    date        TEXT NOT NULL,              -- 'YYYY-MM-DD'
    time        TEXT NOT NULL,              -- 'HH:MM'
    FOREIGN KEY (course_id) REFERENCES COURSES(course_id) ON DELETE CASCADE
);

-- ---------------------------------------------------------------------
-- 6. ATTENDANCE: one record per student per lecture (FR3, FR4, FR5, FR6)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS ATTENDANCE (
    record_id   INTEGER PRIMARY KEY AUTOINCREMENT,
    lecture_id  INTEGER NOT NULL,
    student_id  INTEGER NOT NULL,
    marked_by   INTEGER NOT NULL,           -- instructor who saved the record (FR4)
    status      TEXT NOT NULL CHECK (status IN ('Present', 'Absent', 'Late')),
    marked_at   TEXT NOT NULL DEFAULT (datetime('now', 'localtime')),  -- date + time of saving (FR4)
    FOREIGN KEY (lecture_id) REFERENCES LECTURES(lecture_id) ON DELETE CASCADE,
    FOREIGN KEY (student_id) REFERENCES STUDENTS(student_id) ON DELETE CASCADE,
    FOREIGN KEY (marked_by)  REFERENCES USERS(user_id),
    UNIQUE (lecture_id, student_id)         -- one record per student per lecture
);

-- ---------------------------------------------------------------------
-- 7. AUDIT_LOG: old and new status of every later change (FR4)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS AUDIT_LOG (
    log_id      INTEGER PRIMARY KEY AUTOINCREMENT,
    record_id   INTEGER NOT NULL,
    old_status  TEXT NOT NULL CHECK (old_status IN ('Present', 'Absent', 'Late')),
    new_status  TEXT NOT NULL CHECK (new_status IN ('Present', 'Absent', 'Late')),
    changed_at  TEXT NOT NULL DEFAULT (datetime('now', 'localtime')),
    FOREIGN KEY (record_id) REFERENCES ATTENDANCE(record_id) ON DELETE CASCADE
);

-- ---------------------------------------------------------------------
-- Indexes for the most common queries (percentages, alerts, reports)
-- ---------------------------------------------------------------------
CREATE INDEX IF NOT EXISTS idx_courses_instructor  ON COURSES(instructor_id);
CREATE INDEX IF NOT EXISTS idx_enrollment_course   ON ENROLLMENT(course_id);
CREATE INDEX IF NOT EXISTS idx_lectures_course     ON LECTURES(course_id);
CREATE INDEX IF NOT EXISTS idx_attendance_student  ON ATTENDANCE(student_id);
CREATE INDEX IF NOT EXISTS idx_audit_record        ON AUDIT_LOG(record_id);
