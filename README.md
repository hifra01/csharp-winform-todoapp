# TodoAppWinForm

Sebelum menjalankan project, pastikan database PostgreSQL Anda telah siap.

1. Buat database bernama "todolist" (atau sesuaikan dengan preferensi Anda)
2. Pada database tersebut, buat tabel `tasks` yang terdiri dari kolom `id`, `task`, dan `is_done` dengan syntax SQL berikut:
    ```sql
    CREATE TABLE public.tasks (
        id serial4 NOT NULL,
        task varchar NOT NULL,
        is_done bool NOT NULL DEFAULT false,
        CONSTRAINT tasks_pk PRIMARY KEY (id)
    );
    ```
3. Sesuaikan connection string (variabel `dsn`) pada class DBConnection dengan kredensial database Anda.