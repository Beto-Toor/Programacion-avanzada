#include <iostream>
#include <string>
using namespace std;

struct reg_estudiantes {

    string nombre, carrera, semestre;
    float promedio;

} estudiante[5];

int main() {

    int i;
    
    cout << "-----Registro de estudiantes-----" << endl;

    for(i=0; i<5; i++) {
    
        cout << "\nEstudiante " << i+1 << ":" << endl;
        cout << "Ingresa el nombre del estudiante: ";
        cin >> estudiante[i].nombre;

        cout << "Ingresa la carrera del estudiante: ";
        cin >> estudiante[i].carrera;

        cout << "Ingresa el Semestre del estudiante: ";
        cin >> estudiante[i].semestre;

        cout << "Ingresa el promedio del estudiante: ";
        cin >> estudiante[i].promedio;

    }

    int opcion;

    do {

        cout << "\n-----Menu de busqueda-----" << endl;
        cout << "1. Buscar alumno por nombre" << endl;
        cout << "2. Buscar alumno por carrera" << endl;
        cout << "3. Salir" << endl;
        cout << "Elige una opcion: ";
        cin >> opcion;

        if (opcion == 1) {

            string BuscarNombre;
            cout << "\nIngresa el nombre del alumno a buscar: ";
            cin >> BuscarNombre;
            
            bool encontrado = false;
            for(int j = 0; j < 5; j++) {
                if(estudiante[j].nombre == BuscarNombre) {

                    cout << "\nDatos del estudiante:" << endl;
                    cout << "Nombre:   " << estudiante[j].nombre << endl;
                    cout << "Carrera:  " << estudiante[j].carrera << endl;
                    cout << "Semestre: " << estudiante[j].semestre << endl;
                    cout << "Promedio: " << estudiante[j].promedio << endl;
                    encontrado = true;
                    break;

                }
                
            }
            
            if(!encontrado) {

                cout << "Alumno no registrado en sistema" << endl;

            }

        }

        else if (opcion == 2) {

            string BuscarCarrea;
            cout << "\nIngresa la carrera a buscar: ";
            cin >> BuscarCarrea;
            
            bool encontrado = false;
            cout << "\nListado de todos los alumnos inscritos en " << BuscarCarrea << ":" << endl;
            for(int j = 0; j < 5; j++) {

                if(estudiante[j].carrera == BuscarCarrea) {

                    cout << "- " << estudiante[j].nombre << endl;
                    encontrado = true;

                }

            }
            
            if(!encontrado) {

                cout << "No hay alumnos registrados en esta carrera." << endl;

            }

        }

    } while(opcion != 3);

    return 0;

}