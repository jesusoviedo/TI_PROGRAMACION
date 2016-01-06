package usodellog4j;

/**
 *
 * @author Jesús Oviedo
 * fuente
 * http://programacion.jias.es/2013/03/log4j-tutorial-configuracion-rapida/
 * Como agregar libreria
 * https://www.youtube.com/watch?v=1_P1wGPuG-Q
 */

//para configuracion basica
//import org.apache.log4j.BasicConfigurator;
import org.apache.log4j.PropertyConfigurator;
import org.apache.log4j.Logger;
public class UsoDelLog4j {

    private final static Logger log = Logger.getLogger(UsoDelLog4j.class);
    
    public static void main(String[] args) {
        //para configuracion basica
        //BasicConfigurator.configure();
        
        //se coloca la direccion del archivo log4j.properties
        PropertyConfigurator.configure("C:\\Users\\txtas\\Documents\\NetBeansProjects\\UsoDelLog4j\\src\\usodellog4j\\log4j.properties");
        
        Logger log = Logger.getLogger("Logger de Ejemplo");
        
        log.trace("El menos importante, que se suele usar en la fase de desarrollo");
        log.debug("Información útil para depurar");
        log.info("Información sobre la aplicación que pueden tener cierto interés para ser mostrados en el log");
        log.warn("Advertencias o fallos sin importancia para la ejecución del programa");
        log.error("Errores importantes, pero que no obligan a terminar la aplicación");
        log.fatal("Errores que obligan a terminar la aplicación");
    }
}
