#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

#ifdef __cplusplus
extern "C" {
#endif

float GetNativeScreenScale() {
    UIScreen *screen = [UIScreen mainScreen];
    return screen ? screen.nativeScale : 1.0f;
}

#ifdef __cplusplus
}
#endif