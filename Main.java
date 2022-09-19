import java.util.Scanner;
import java.io.File;
public class Main {
    static String path = System.getProperty("user.dir");
    static File wd = new File(path);
    File f = new File(wd,"szoveg.txt");
    protected static void hello(String[] cmd){
        System.out.println("Hello world!");
    }

    protected static void pwd(String[] cmd){
        String path = System.getProperty("user.dir");
        File dir = new File(path);
        System.out.println(path);
        int db = dir.listFiles().length;
        System.out.println(db);
    }

    protected static void ls(String[] cmd){
        File[] fl = wd.listFiles();
        for (int i = 0; i < fl.length;i++) {
            System.out.println(fl[i]);
        }
    }

    public static void main(String[] args) {

        while(true){
            Scanner s = new Scanner(System.in);
            System.out.println("Ird be a szavakat");
            String cmd[] = s.nextLine().split(" ");
            if(cmd[0].equals("exit")){
                System.exit(0);
            }else if (cmd[0].equals("hello")) {
                hello(cmd);
            }else if(cmd[0].equals("pwd")){
                pwd(cmd);
            }
            else if(cmd[0].equals("ls")){
                ls(cmd);
            }
        }
    }


}