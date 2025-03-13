# Project Description: Secure Password Hashing in C#

## Overview
This project is a simple implementation of secure password hashing and verification using **PBKDF2 (Password-Based Key Derivation Function 2)** in C#. It utilizes the `Microsoft.AspNetCore.Cryptography.KeyDerivation` package to hash passwords with a strong cryptographic algorithm, ensuring security against brute-force attacks.

## Key Features

### Secure Password Hashing
- Uses PBKDF2 with **HMAC-SHA256** for hashing.
- Includes a randomly generated **32-byte salt** to ensure uniqueness.
- Uses **310,000 iterations** for key stretching, following **OWASP 2023** recommendations.

### Password Verification
- Splits the stored hash to extract the salt.
- Recomputes the hash using the entered password and the extracted salt.
- Uses a **constant-time comparison** (`CryptographicOperations.FixedTimeEquals`) to prevent **timing attacks**.

### Security Enhancements
- High iteration count increases **computational cost**, making brute-force attacks impractical.
- Uses a **secure random number generator** (`RandomNumberGenerator.Create()`) for salt generation.
- Stores the password hash in a **salt.hash** format for easy retrieval and verification.

## Dependencies

- **NuGet Package:** `Microsoft.AspNetCore.Cryptography.KeyDerivation`

Install it using:

```sh
dotnet add package Microsoft.AspNetCore.Cryptography.KeyDerivation
```

## Usage

1. Create an instance of `PasswordHasher`.
2. Use `HashPassword(string password)` to generate a **hashed password**.
3. Use `VerifyPassword(string enteredPassword, string storedHash)` to check if an entered password matches the stored hash.

## Example Output

```yaml
Hashed Password: c2FsdFZhbHVlVG9CZVN0b3JlZC4xMkNhc1hZMjNkU2VjdXJl
Password match: True
```

## Applications

- **User authentication systems** (e.g., login systems).
- **Web applications** requiring **secure password storage**.
- **APIs** needing password hashing before storing in databases.

This project demonstrates a **best-practice approach** for handling user passwords securely in C# applications. 🚀
