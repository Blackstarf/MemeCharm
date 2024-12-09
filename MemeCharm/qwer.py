import io
import numpy as np
from PIL import Image
import seam_carving

def Jmix(path):
	# Загружаем изображение
    src = np.array(Image.open(path))
    # Получаем размеры исходного изображения
    src_h, src_w, _ = src.shape

    # Изменяем размер изображения с помощью seam carving
    W = src_w * 0.4
    H = src_h * 0.4
    dst = seam_carving.resize(
        src,  # исходное изображение (RGB или оттенки серого)
        size=(W, H),  # целевой размер
        energy_mode="backward",  # режим энергии (обратный или прямой)
        order="width-first",  # порядок обработки (по ширине или высоте)
        keep_mask=None,  # маска объектов для защиты от удаления
    )

    # Создаем объект изображения из массива NumPy
    processed_image = Image.fromarray(dst)

    # Отображаем обработанное изображение
    #processed_image.show()

    # Сохраняем обработанное изображение на компьютере
    #processed_image.save("photo.jpg")

    img_byte_array = io.BytesIO()
    processed_image.save(img_byte_array, format='PNG')
    byte_array_value = img_byte_array.getvalue()

    return byte_array_value