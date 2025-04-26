# 🎮 FrogsGameWindowsFormsApp
🐸 Игра _"Лягушки"_, написанная в процессе изучения технологии **Windows Forms** и работы с изображениями.

![Снимок экрана 2025-04-26 180637](https://github.com/user-attachments/assets/4a50d591-d396-46b7-ada9-33cf3b8b507a)

## 📃 Описание
### ⚖️ Правила игры
**Цель игры** — расположить лягушек, которые смотрят влево, в левую часть, а остальных - в правую часть за **минимальное** количество перепрыгиваний.

Прыгать можно на листок, если он находится рядом или через **1** лягушку

## 🎮 Геймплей
Пример геймплея игры:

https://github.com/user-attachments/assets/4a71f2f8-5a99-4db7-a6cf-2ff06d7cc970

## 🔧 Техническая часть
* Проект реализован на платформе **Windows Forms**.

* Для работы с изображениями используется компонент **PictureBox**.

### 🧩 Архитектура
Структура каталога решения:

![Снимок экрана 2025-04-26 182120](https://github.com/user-attachments/assets/456e738e-7ee3-4882-a9da-b4e784922c15)

### 🖼️ Работа с изображениями
Для обработки нажатия левой кнопкой мыши по изображению (кроме изображения пустой кувшинки) написан обработчик собыия **PictureBox_Click**, который внутри содержит метод **Swap**, реализующий _"прыжок"_ лягушки, и метод **CheckWinning**, проверяющий, выполняется ли условие победы:

```C#
private void PictureBox_Click(object sender, EventArgs e)
{
    Swap((PictureBox)sender);
    CheckWinning();
}

private void Swap(PictureBox clickedPicture)
{
    var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

    if (distance > 2)
    {
        MessageBox.Show("Невозможный ход!");
        return;
    }

    (emptyPictureBox.Location, clickedPicture.Location) = (clickedPicture.Location, emptyPictureBox.Location);
    countMoves++;
    countMovesLabel.Text = countMoves.ToString();
}

private void CheckWinning()
{
    if(Iswin())
    {
        if (countMoves == minimumMoves)
        {
            MessageBox.Show("Поздравляю! Вы выиграли!", "Конец Игры");
        }
        else
        {
            var result = MessageBox.Show("Вы справились не за оптимальное количество ходов. Хотите начать заново?", "Конец Игры", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                Application.Restart();
            }
        }
    }
}
```
