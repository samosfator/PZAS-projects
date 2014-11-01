package ua.samosfator.txtDB;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.Properties;

/**
 * Організувати файл даних з вказаною нижче структурою та передбачити функції, які дозволяють:
 * коригування обраного запису файла;
 * пошук інформації за різними полями;
 * додавання записів у кінець бази даних;
 * вилучення інформації з бази даних.
 */

public class DB {
    private Properties prop = new Properties();

    public DB(String filename) {
        try (FileInputStream inputStream = new FileInputStream(filename)) {
            prop.load(inputStream);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    //пошук інформації за різними полями
    public String get(String field) {
        return prop.getProperty(field);
    }

    //додавання записів у кінець бази даних
    public void set(String field, String value) {
        prop.setProperty(field, value);
    }

    //вилучення інформації з бази даних
    public void delete(String field) {
        prop.remove(field);
    }
}
